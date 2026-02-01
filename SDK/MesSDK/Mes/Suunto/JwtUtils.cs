using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MesSDK
{
    public class JwtUtils
    {
        private static readonly Regex VALID_JWT_PATTERN = new Regex("^(\\S+)\\.(\\S+)\\.(\\S+)$");
        private static readonly Regex SPLIT_PATTERN = new Regex("\\.");

        private static readonly IJwtAlgorithm signatureAlgorithm = new HMACSHA256Algorithm();//HMACSHA256加密
        private static readonly IJsonSerializer objectMapper = new JsonNetSerializer();//序列化和反序列
        private static readonly IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//Base64编解码
        private static readonly IDateTimeProvider provider = new UtcDateTimeProvider();//UTC时间获取
        private static readonly DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
 
        /// <summary>
        /// 生成令牌
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="payload"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        private static string DoCreateJwt(IDictionary<string, object> headers, IDictionary<string, object> payload, string secretKey)
        {
            JwtEncoder encoder = new JwtEncoder(signatureAlgorithm, objectMapper, urlEncoder); 
            return headers == null ? encoder.Encode(payload, secretKey) : encoder.Encode(headers, payload, secretKey);
        }
          
        /// <summary>
        ///  
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="actionBefore"></param>
        /// <param name="secretKey"></param>
        /// <param name="expireSeconds"></param>
        /// <returns></returns>
        private static string DoCreateJwt(string businessId, Action<Dictionary<string, object>> actionBefore, string secretKey, long expireSeconds)
        {
            long now = CurrentTimeSeconds();
            /*
             * iss: jwt签发者 sub: jwt所面向的用户,一个json格式的字符串 aud: 接收jwt的一方 exp:
             * jwt的过期时间，这个过期时间必须要大于签发时间 nbf: 定义在什么时间之前，该jwt都是不可用的. iat: jwt的签发时间 jti:
             * jwt的唯一身份标识(id)，主要用来作为一次性token,从而回避重放攻击。 根据业务需要，这个可以设置为一个不重复的值
             */
            var payload = new Dictionary<string, object>
            {
                { "jti", businessId ?? Guid.NewGuid().ToString()},
                //{ "iss","JWT.SERVER"},//发行人   
                //{ "aud", "JWT.CLIENT" }, //用户
                { "nbf", now - 3 * 60 },//	// 两个系统的话，时间不能超过3分钟误差 
                { "iat", now } //发布时间   
            };
            //
            actionBefore.Invoke(payload);

            //
            if (expireSeconds > 0)
            {
                payload.Add("exp", now + expireSeconds);
            }
            return DoCreateJwt(null, payload, secretKey);
        }
         
        /// <summary>
        /// 取时间戳，高并发情况下会有重复。想要解决这问题请使用sleep线程睡眠1毫秒。
        /// </summary> 
        /// <returns>返回一个长整数时间戳</returns>
        private static long CurrentTimeSeconds()
        { 
            return (DateTime.Now.ToUniversalTime().Ticks - unixEpoch.ToUniversalTime().Ticks) / 10000000; 
        }

        /// <summary>
        /// 解析Jwt
        /// </summary>
        /// <param name="jwt"></param>
        /// <param name="secretKey"></param>
        /// <param name="verify"></param>
        /// <returns></returns>
        private static string DoParseJwt(string jwt, string secretKey, bool verify)
        {
            IJwtValidator validator = new JwtValidator(objectMapper, provider);//用于验证JWT的类
            IJwtDecoder decoder = new JwtDecoder(objectMapper, validator, urlEncoder, signatureAlgorithm);//用于解析JWT的类
            return decoder.Decode(jwt, secretKey, verify);
        }

        /**
	     * 解析 jwt 字符串为 Claims对象
	     * 
	     * @param jwt
	     * @param secretKey
	     * @return
	     * @throws BadPaddingException
	     * @throws IllegalBlockSizeException
	     * @throws UnsupportedEncodingException
	     * @throws NoSuchPaddingException
	     * @throws NoSuchAlgorithmException
	     * @throws InvalidKeyException
	     */
        private static string DoParseJwt(string jwt, string secretKey)
        {
            if (jwt == null || jwt.Trim().Length == 0)
            {
                return null;
            }
            if (!VALID_JWT_PATTERN.IsMatch(jwt))
            {
                throw new Exception("Invalid jwt strings. JWT strings must contain exactly 2 period characters:\t" + jwt);
            }
            return DoParseJwt(jwt, secretKey, true);
        }

        /**
         * 解析Jwt令牌
         * 
         * @param jwt
         * @param secretKey
         * @return
         */
        public static IDictionary<string, object> ParseJwt(string jwt, string secretKey)
        {
            try
            {
                string payload = DoParseJwt(jwt, secretKey);
                if (payload == null) {
                    return null;
                }
                return objectMapper.Deserialize<Dictionary<string, object>>(payload); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error parse jwt:" + e.StackTrace); 
                return null;
            }
        }

        /// <summary>
        /// 校验是否通过
        /// </summary>
        /// <param name="jwt"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static bool Validate(string jwt, string secretKey)
        {
            try
            {
                string payload = DoParseJwt(jwt, secretKey);
                return payload != null && payload.Trim().Length > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error parse jwt:" + e.StackTrace);
                return false;
            }
        }

        /**
        * 生成 jwt 令牌
        * 
        * @param businessId 业务防重ID 
        * @param secretKey  私钥
        * @param expire     过期时间秒，expireSeconds小于等于0则不设置过期时间
        * @param beforeBuild 构建前处理参数
        * @return
        */
        public static string CreateJwt(string businessId, string secretKey, long expireSeconds, Action<Dictionary<string, object>> beforeBuild)
        {
            try
            {
                return DoCreateJwt(businessId, beforeBuild, secretKey, expireSeconds);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error create jwt:" + e.StackTrace);
            }
            return null;
        }

        /**
         * 生成 jwt 令牌
         * 
         * @param businessId 业务防重ID
         * @param subject    主题
         * @param secretKey  私钥
         * @param expire     过期时间秒，expireSeconds小于等于0则不设置过期时间
         * @return
         */
        public static string CreateJwt(string businessId, string subject, string secretKey, long expireSeconds)
        {
            try
            {
                return DoCreateJwt(businessId, payload => {
                    if (subject != null)
                    {
                        payload.Add("sub", subject); //主题
                    }
                }, secretKey, expireSeconds);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error create jwt:" + e.StackTrace);  
            }
            return null;
        }

        /**
         * 重新生成JWT令牌
         * 
         * @param claims    原令牌
         * @param secretKey 密钥
         * @return
         */
        public static string UpdateJwt(string jwt, string secretKey)
        {
            if (jwt == null)
            {
                return null;
            }
            try
            {
                IDictionary<string, object> payload = ParseJwt(jwt, secretKey);
                if (payload == null)
                {
                    return null;
                } 
                long exp = -1;
                if (payload.ContainsKey("exp"))
                {
                    exp = (long) payload["exp"];
                }
                long iat = -1;
                if (payload.ContainsKey("iat"))
                {
                    iat = (long) payload["iat"];
                }
                if (exp < 0)
                {
                    return jwt;
                }
                if (iat < 0 || exp <= iat)
                {
                    // 无效的jwt
                    return null;
                }
                long now = CurrentTimeSeconds();
                payload["exp"] = now + (exp - iat);
                payload["iat"] = now;
                return DoCreateJwt(null, payload, secretKey);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error update jwt:" + e.StackTrace); 
            }
            return null;
        }

        /**
         * 不验证jwt有效性，直接获取jwt中的head部分，强烈不建议用此方法验证外部Token有效性
         * 
         * <br><br> 需要验证token有效性，请使用 {@code JwtUtils.parseJwt(jwt)}
         * 
         * @param jwt
         * @return
         */
        public static string DirectHeader(string jwt)
        {
            if (jwt == null)
            {
                return null;
            }
            try
            {
                IJwtValidator validator = new JwtValidator(objectMapper, provider);//用于验证JWT的类
                IJwtDecoder decoder = new JwtDecoder(objectMapper, validator, urlEncoder, signatureAlgorithm);//用于解析JWT的类
                return decoder.DecodeHeader(jwt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error get direct header:" + e.StackTrace); 
            }
            return null;
        }

        /**
         * 不验证jwt有效性，直接获取jwt中的payload部分，强烈不建议用此方法验证外部Token有效性
         * 
         * <br><br> 需要验证token有效性，请使用 {@code JwtUtils.parseJwt(jwt)}
         * 
         * @param jwt
         * @return
         */
        public static IDictionary<string, object> DirectPayload(string jwt)
        {
            if (jwt == null)
            {
                return null;
            }
            try
            {
                IJwtValidator validator = new JwtValidator(objectMapper, provider);//用于验证JWT的类
                IJwtDecoder decoder = new JwtDecoder(objectMapper, validator, urlEncoder, signatureAlgorithm);//用于解析JWT的类
                return decoder.DecodeToObject(jwt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error get direct payload:" + e.StackTrace);
            }
            return null;
        }

        /// <summary>
        /// 转换为JSON
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(object obj)
        {
            return objectMapper.Serialize(obj);
        }

        /// <summary>
        /// 转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T FromJson<T>(string json) {
            return objectMapper.Deserialize<T>(json);
        }
    }
	 
}
