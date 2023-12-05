using MealSystem.Commons.Enums;
using Microsoft.OpenApi.Extensions;

namespace MealSystem.Commons
{
    public class ApiResponse<T>
    {
        public ApiResponse(StatusEnum code)
        {
            Code = code;
            Message = code.GetDisplayName();
            
        }

        public ApiResponse(StatusEnum code, string message)
        {
            Code = code;
            Message = message;
        }

        public ApiResponse(StatusEnum code, T? tdata)
        {
            Code = code;
            TData = tdata;
        }

        public StatusEnum Code { get; private set;}
        
        public string Message { get;  set;}

        public T? TData { get; set;}


    }
}
