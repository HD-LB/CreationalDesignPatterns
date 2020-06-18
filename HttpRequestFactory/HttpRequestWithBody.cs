using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestFactory
{
    public class HttpRequestWithBody : HttpRequest, IHttpRequestWithBody
    {
        public HttpRequestWithBody(string method, string url, string[] customHeaders, string mimeType, string body)
            : base(method, url, customHeaders)
        {
            this.MimeType = mimeType;
            this.Body = body;
        }

        public string Body { get ; set; }
        public string MimeType { get; set ; }

        public override string ToString()
        {
            return base.ToString() + "\r\nContent-type: " + this.MimeType + "\r\nBODY:\r\n" + this.Body ;
        }
    }
}
