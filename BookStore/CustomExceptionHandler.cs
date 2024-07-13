using Microsoft.AspNetCore.Diagnostics;
using System.Web.Http.ExceptionHandling;

namespace BookStore
{
    public class CustomExceptionHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}