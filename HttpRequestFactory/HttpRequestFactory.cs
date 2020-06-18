using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestFactory
{
    public class HttpRequestFactory
    {
        public static IHttpRequest CreateRequest(string method, string url, string[] customHeaders = null, string mimeType = "*/*", string body = "")
        {
            if (new string[] { "get", "options", "head" }.Contains(method))
            {
                return new HttpRequest(method, url, customHeaders);
            }

            return new HttpRequestWithBody(method, url, customHeaders, mimeType, body);
        }

    }
}
