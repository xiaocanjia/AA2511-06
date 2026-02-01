using System;
using System.IO;
using System.Net;
using System.Text;
using System.Globalization;

namespace MesSDK
{
    
    public enum HttpVerb
    {
        Get,
        Post
    }
    /// <summary>
    /// http通讯帮助类
    /// </summary>
    public class HttpHelper
    {
        public string PostData { get; set; }
       
        /// <summary>
        /// API地址
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// 调用方式
        /// </summary>
        public HttpVerb Method { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        public string ContentType { get; set; } = "application/json;charset=utf-8";

        /// <summary>
        /// 默认15000毫秒
        /// </summary>
        public int Timeout { get; set; } = 50000;

        /// <summary>
        /// key钥匙
        /// </summary>
        public string Tokenkey { get; set; } = "Man@Su%!unto&23";
        
        /// <summary>
        /// 新建（地址）
        /// </summary>
        /// <param name="address"></param>
        public HttpHelper(string address)
        {
            EndPoint = address + "manufacture/api/allot/updateStatus/programData";
            Method = HttpVerb.Get;
            ContentType = ContentType;
            PostData = "{}";
        }

        /// <summary>
        /// 做post请求
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        public string Post(string data)
        {
            try
            {
                string token = JwtUtils.CreateJwt("suunto-manufacture", Tokenkey, 30, config =>
                {
                    config["sub"] = "manufacture-line";
                    config["aud"] = "manufacture";
                    config["iss"] = "suunto";
                });
                var service = new Uri(EndPoint);
                var request = WebRequest.CreateHttp(service);
                request.Method = "POST";
                request.ContentType = ContentType;

                request.Headers.Set("Authorization", "Bearer " + token);
                request.Headers.Set("Accept-Language", "zh-CN,zh;q=0.8,en;q=0.2");
                request.Accept = "application/json";
                var bytes = Encoding.UTF8.GetBytes(data);
                request.ContentLength = bytes.Length;
                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        var message = string.Format(CultureInfo.CurrentCulture, "Request failed. Received HTTP {0}", response.StatusCode);
                        throw new WebException(message);
                    }
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                    return responseValue;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Request server
        /// </summary>
        /// <param name="parameters">http通讯参数</param>
        /// <returns></returns>
        public string Get(string parameters)
        {
            try
            {
                var service = new Uri(EndPoint + parameters);
                var request = WebRequest.CreateHttp(service);
                request.Method = "GET";
                request.Timeout = Timeout;
                request.KeepAlive = true;
                request.ContentLength = 0;
                request.ContentType = ContentType;

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        var message = string.Format(CultureInfo.CurrentCulture, "Request failed. Received HTTP {0}", response.StatusCode);
                        throw new WebException(message);
                    }
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                            using (var reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                            }
                    }
                    return responseValue;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 下载更新二进制文件
        /// </summary>
        /// <param name="parameters">http通讯参数</param>
        /// <returns></returns>
        public byte[] DownLoad(string parameters)
        {
            var service = new Uri(EndPoint + parameters);
            var request = WebRequest.CreateHttp(service);
            request.Timeout = Timeout;
            request.KeepAlive = true;
            request.Method = Method.ToString().ToUpper(CultureInfo.CurrentCulture);
            request.ContentLength = 0;
            request.ContentType = ContentType;

            if (Method == HttpVerb.Post)
            {
                var bytes = Encoding.UTF8.GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format(CultureInfo.CurrentCulture, "Request failed. Received HTTP {0}", response.StatusCode);
                    throw new WebException(message);
                }
                using (var result = new MemoryStream())
                {
                    const int bufferLen = 2048;
                    var buffer = new byte[bufferLen];
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            var len = responseStream.Read(buffer, 0, bufferLen);
                            while (len > 0)
                            {
                                result.Write(buffer, 0, len);
                                len = responseStream.Read(buffer, 0, bufferLen);
                            }
                        }
                    }
                    return result.ToArray();
                }
            }
        }

    }

}
