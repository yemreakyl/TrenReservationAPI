using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class CustomResponseDto<T>
    {
        //Kulanıcıya başarılı yada başarısız istekler sonucunda standart dönüşler yapabilmek için bir dto oluşturdum

        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }

        public T Data { get; set; }
        //Aşağı kısımda static factory methodlarımı yazıyorum
        //Başarılı olma durumuna karşılık
        public static CustomResponseDto<T> Success(int statuscode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statuscode };
        }
        //Birden fazla hata olma durumuna karşılık
        public static CustomResponseDto<T> Fail(int statuscode, List<String> errors)
        {
            return new CustomResponseDto<T> { Errors = errors, StatusCode = statuscode };
        }
        //Bir tane hata olma duruma karşılık
        public static CustomResponseDto<T> Fail(int statuscode, string error)
        {
            return new CustomResponseDto<T> { Errors = new List<String> { error }, StatusCode = statuscode };
        }

    }
}
