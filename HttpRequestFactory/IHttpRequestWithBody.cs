using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestFactory
{
    public interface IHttpRequestWithBody : IHttpRequest
    {
        string Body { get; set; }
        
        string MimeType { get; set; }
    }
}
