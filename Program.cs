using System;

using System.Threading.Tasks;
using GetHttp;

namespace Test_GetHttpResponse
{
    class Program
    {
        public async Task Main(string[] args)
        {
            string username = "dupont01";
            string password = "admin1:"
            string url =  "http://jirahost:8080";

            //Send the request via Http protocol to the JIRA server & Get the response in a string (the string is Json formated)
            //------------------------------------------------------------------------------------------------------------------
            string result;
            result = await Http.GetHttpResponse(username, password, url);

        }
    }
}
