using Newtonsoft.Json;

namespace OnlineRandevuApp.API.Core.Utilities
{
    public class BaseResponse
    {
        [JsonProperty(Required = Required.Always)]
        public bool HasError { get; set; }
        [JsonProperty(Required = Required.Always)]
        public bool HasWarning { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Message { get; set; }
        public long Id { get; set; }

        public BaseResponse()
        {
            HasError = false;
            HasWarning = false;
            Message = "";
        }

        public BaseResponse SetError(string message = null)
        {
            HasError = true;
            HasWarning = false;
            Message = message ?? "Server Error";

            return this;
        }
        public BaseResponse SetWarning(string message = null)
        {
            HasWarning = true;
            HasError = false;
            Message = message ?? "Undefined Warning ";

            return this;
        }

        public T SetError<T>(string message) where T : BaseResponse
        {
            HasError = true;
            HasWarning = false;
            Message = message;

            return (T)this;
        }
        public T SetWarning<T>(string message) where T : BaseResponse
        {
            HasWarning = true;
            HasError = false;
            Message = message;

            return (T)this;
        }

        public static BaseResponse GetError(string message)
        {
            var ret = new BaseResponse();
            ret.SetError(message);
            return ret;
        }
        public static BaseResponse GetWarning(string message)
        {
            var ret = new BaseResponse();
            ret.SetWarning(message);
            return ret;
        }

        public static T GetError<T>(string message) where T : BaseResponse, new()
        {
            var ret = new T();
            ret.SetError(message);
            return ret;
        }
        public static T GetWarning<T>(string message) where T : BaseResponse, new()
        {
            var ret = new T();
            ret.SetWarning(message);
            return ret;
        }

        public BaseResponse SetSuccess(string message = "İşlem Başarı ile Gerçekleştirildi.")
        {
            HasError = false;
            HasWarning = false;
            Message = message;

            return this;
        }

        public T SetSuccess<T>(string message = "İşlem Başarı ile Gerçekleştirildi.") where T : BaseResponse
        {
            HasError = false;
            HasWarning = false;
            Message = message;

            return (T)this;
        }

        public static BaseResponse GetSuccess(string message = "")
        {
            var ret = new BaseResponse();
            ret.SetSuccess(message);
            return ret;
        }

        public static T GetSuccess<T>(string message = "") where T : BaseResponse, new()
        {
            var ret = new T();
            ret.SetSuccess(message);
            return ret;
        }

    }
    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
