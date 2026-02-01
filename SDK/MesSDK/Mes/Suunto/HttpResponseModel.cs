namespace MesSDK
{
    public class HttpResponseModel<T>
    {
        public int code { get; set; }

        public T data { get; set; }

        public string message { get; set; }
    }

    public class WatchData
    {
        public string bleAddr { get; set; }

        public string hashCode { get; set; }

        public string pKey { get; set; }

        public string pcbaSerial { get; set; }

        public string programStatus { get;set; }

        public string sn { get; set; }

        public string testStatus { get; set; }

        public string watchSerial { get; set; }

        public string wifiAddr { get; set; }

        public string agTestStatus { get; set; }
    }
}
