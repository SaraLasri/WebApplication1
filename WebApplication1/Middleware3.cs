using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware3
    {
        private readonly ILogger logger;
        private readonly RequestDelegate _next;

        public Middleware3(RequestDelegate next, ILogger<Middleware3> logger)
        {
            _next = next;
            this.logger = logger;

        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("hello !!!!!!!!!");
            logger.LogDebug($"next start{httpContext.Request.Path}");

            await _next(httpContext);
            await httpContext.Response.WriteAsync(httpContext.Request.Method.ToString());
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Middleware3Extensions
    {
        public static IApplicationBuilder UseMiddleware3(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware3>();
        }
    }
}
