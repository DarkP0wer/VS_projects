using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_tut_1
{
    public class TokenMiddleware
    {
        RequestDelegate _next;
        string _pattern;

        public TokenMiddleware(RequestDelegate next, string pattern)
        {
            _next = next;
            _pattern = pattern;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];

            if (token != _pattern)
            {
                context.Response.StatusCode = 403;
            }
            else
                await _next(context);
        }
    }

    public static class TokenExteinsions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
    }
}
