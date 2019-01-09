using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Net.Http;

namespace AspNetCoreApiTemplate.Filters
{
    /// <summary>
    /// 共通エラー処理
    /// </summary>
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            string exceptionMessage = context.Exception.InnerException == null ?
                context.Exception.Message :
                context.Exception.InnerException.Message;
            
            context.Result = new JsonResult(new
            {
                StatusCode = HttpStatusCode.InternalServerError,
                ErrorMessage = exceptionMessage
            });
        }
    }
}
