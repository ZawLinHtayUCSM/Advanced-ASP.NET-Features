using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApi.DI.CustomHandlers
{
    public class RequestValidateHandler:DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = base.SendAsync(request, cancellationToken);

            if (response.Result.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("URL is not valid!")
                };

                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(resp);
                return tsc.Task;
            }
        }
    }
}