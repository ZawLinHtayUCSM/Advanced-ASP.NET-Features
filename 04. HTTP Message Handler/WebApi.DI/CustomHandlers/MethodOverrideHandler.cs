﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApi.DI.CustomHandlers
{
    public class MethodOverrideHandler:DelegatingHandler
    {
        readonly string[] _methods = { "DELETE", "PUT", "PATCH" };
        const string _header = "X-HTTP-Method-Override";

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if(request.Method == HttpMethod.Post && request.Headers.Contains(_header))
            {
                var method = request.Headers.GetValues(_header).FirstOrDefault();
                if(_methods.Contains(method, StringComparer.InvariantCultureIgnoreCase))
                {
                    request.Method = new HttpMethod(method);
                }
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}