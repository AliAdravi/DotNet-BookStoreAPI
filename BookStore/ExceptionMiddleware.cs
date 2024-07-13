using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;
namespace BookStore
{
    public static class ExceptionMiddleware
    {
        public static void AppExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = context.Response.StatusCode;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        // errorService.LogError(contextFeature.Error, 0, context.Connection.RemoteIpAddress.ToString());
                        var error = new ErrorDetail()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error?.Message!
                        };
                        var jsonError = JsonSerializer.Serialize(error);
                        await context.Response.WriteAsync(jsonError);
                    }
                });
            });
        }
    }

    public class ErrorDetail
    {
        public int StatusCode { get; set; }
        public string Message { get; set; } = default!;
    }
}
