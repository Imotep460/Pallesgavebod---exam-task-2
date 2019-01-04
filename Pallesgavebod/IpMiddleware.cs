using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse
{
    public class IpMiddleware
    {
        private RequestDelegate _next;

        public IpMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            HashSet<string> DeniedIps = new HashSet<string>() { "102.120.03.120" };
            var ip = context.Connection.RemoteIpAddress.ToString();

            //string ip = "102.120.03.120";

            if (DeniedIps.Contains(ip))
            {
                context.Response.StatusCode = 403;
                return;
            }

            await _next(context);

            await context.Response.WriteAsync("<p><b>Your Ip address is: </b>" + ip + "</p>");
        }
    }
}