using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse
{
    public class TimerMiddelware
    {
        private RequestDelegate _next;

        public TimerMiddelware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await _next(context);

            stopwatch.Stop();
            await context.Response.WriteAsync("<p>" + stopwatch.Elapsed + "</p>");
        }
    }
}