using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        
        
        [JsonIgnore]
        public bool IsSuccessfull { get; set; }
        public ErrorDto Error { get; set; }
        public static Response<T> Success (T data , int statuscode)
        {
            return new Response<T> { Data = data , StatusCode = statuscode , IsSuccessfull = true
            };
        }
        public static Response<T> Success(int statuscode)
        {
            return new Response<T>{Data = default, StatusCode = statuscode , IsSuccessfull = true};
        }
        public static Response<T> Fail(string error ,int statuscode , bool show)
        {
            return new Response<T> { StatusCode = statuscode  ,Error = new ErrorDto(error,show) ,IsSuccessfull = false};
        }
        public static Response<T> Fail(ErrorDto error, int statuscode, bool show)
        {
            return new Response<T> { StatusCode = statuscode, Error = error, IsSuccessfull = false };
        }



    }
}
