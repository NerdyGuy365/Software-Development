using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NerdyGuy.Services.NetCore.Example.Middleware
{
    public class LoggingMiddleware
    {
        private RequestDelegate nextDelegate;

        public LoggingMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine("=== Logging Before ===");
            await nextDelegate.Invoke(context);
            Debug.WriteLine("=== Logging After ===");
        }
    }
}
