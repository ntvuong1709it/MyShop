using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MyShop.Infastructure.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace MyShop.Infastructure.Middleware
{
    public static class ResponseWrapperExtensions
    {
        public static IApplicationBuilder UseResponseWrapper(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseWrapper>();
        }
    }

    public class ResponseWrapper
    {
        private readonly RequestDelegate _next;

        public ResponseWrapper(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var currentBody = context.Response.Body;

            using (var memoryStream = new MemoryStream())
            {
                //set the current response to the memorystream.
                context.Response.Body = memoryStream;

                await _next(context);

                //reset the body 
                context.Response.Body = currentBody;
                memoryStream.Seek(0, SeekOrigin.Begin);

                var readToEnd = new StreamReader(memoryStream).ReadToEnd();
                
                CommonApiResponse result;
                var objResult = ParseReponseContent(readToEnd);

                if (HttpHelper.IsSuccessStatusCode(context.Response.StatusCode))
                {
                    result = CommonApiResponse.Create((HttpStatusCode) context.Response.StatusCode, objResult, null);
                }
                else
                {
                    result = CommonApiResponse.Create((HttpStatusCode)context.Response.StatusCode, null, objResult.ToString());
                }

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }
        }

        

        private object ParseReponseContent(string result)
        {
            try
            {
                JSchema schema = JSchema.Parse(result);
                return JsonConvert.DeserializeObject(result);
            }
            catch (Exception e)
            {
                return result;
            }
        }
    }

    public class CommonApiResponse
    {
        public static CommonApiResponse Create(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            return new CommonApiResponse(statusCode, result, errorMessage);
        }

        public int StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public object Result { get; set; }

        public bool IsSuccess { get; set; }

        protected CommonApiResponse(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            StatusCode = (int)statusCode;
            Result = result;
            ErrorMessage = errorMessage;
            IsSuccess = HttpHelper.IsSuccessStatusCode(StatusCode);
        }
    }
}