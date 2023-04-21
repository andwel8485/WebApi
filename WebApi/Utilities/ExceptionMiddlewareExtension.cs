using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using WebApi.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace WebApi.Utilities
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddlewareExtension
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddlewareExtension(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }

            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            } 
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error from the custom middleware."
            }.ToString());
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionMiddlewareExtensionExtensions
    {
        public static void UseMiddlewareExtension(this WebApplication app)
        {
            app.UseMiddleware<ExceptionMiddlewareExtension>();
            //app.UseExceptionHandler(appError =>
            //{
            //    appError.Run(async context =>
            //    {
            //        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //        context.Response.ContentType = "application/json";
            //        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
            //        if (contextFeature != null)
            //        {
            //            await context.Response.WriteAsync(new ErrorDetails()
            //            {
            //                StatusCode = context.Response.StatusCode,
            //                Message = "Internal Sever Error."
            //            }.ToString());
            //        }
            //    });
            //});
            
            
            //return builder.UseMiddleware<ExceptionMiddlewareExtension>();
        }
    }
}

