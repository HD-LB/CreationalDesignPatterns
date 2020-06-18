using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestFactory
{
    class HttpRequestFactoryMain
    {
        static void Main(string[] args)
        {
            var requests = new List<IHttpRequest>()
            {
                HttpRequestFactory.CreateRequest("get", "google.com", new string[]{"hello", "from-the-lunies"}),
                HttpRequestFactory.CreateRequest("post", "2lunatix.com", new string[]{"message", "I-am-here" }, "multipart/form", "homework.zip")
            };

            requests.ForEach(Console.WriteLine);

        }
    }
}
