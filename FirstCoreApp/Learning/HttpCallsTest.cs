using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class HttpCallsTest
    {
        private HttpClient jose = new HttpClient();

        public HttpCallsTest(HttpClient jose)
        {
            this.jose = jose;
            //https://google.com
        }
    }
}
