using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware3
    {
        private readonly RequestDelegate _next;

        public Middleware3(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("hello Sara!!!");
            return _next(httpContext);
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
