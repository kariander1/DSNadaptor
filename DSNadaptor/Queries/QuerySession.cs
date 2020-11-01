using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
namespace DSNadaptor
{
    class QuerySession
    {


        public RestClient restClient { get; set; }
        public RestRequest restRequest { get; set; }
        public IRestResponse restResponse { get; set; }
        public string BaseURI { get; set; }
        public string BaseURIformat { get; set; }
        public string server { get; set; }
        public CancellationTokenSource cancelToken { get; set; }
        public QuerySession(string server, int requestTO,string baseURI,bool proxy_usage,string proxy_server, int proxy_port,Cookie cookie=null)
        {
            this.server = server;
            this.BaseURIformat = baseURI;
            this.BaseURI = Build_URI();
            this.restClient = new RestClient(BaseURI);
            if(proxy_usage)
            {
                this.restClient.Proxy = new WebProxy(proxy_server, proxy_port);
            }
            if (cookie != null)
            {
                this.restClient.CookieContainer = new CookieContainer();

                this.restClient.CookieContainer.Add(cookie);
                //cookie.Name, cookie.Value);

            }
            //TODO Add cookie
            //      this.restClient.Proxy = new WebProxy();
            this.restRequest =new RestRequest("/", Method.GET);
            this.restRequest.Timeout = requestTO;


        }
        public string Build_URI()
        {
            return this.BaseURIformat.Replace("<server>",this.server);
        }
        public string FormatParameters(Hashtable data)
        {
            string tralier = "?";
            bool first = true;
            foreach (DictionaryEntry pair in data)
            {
                if(!first)
                {
                    tralier += "&";
                }
                first = false;
                tralier += pair.Key.ToString()+"=";
                tralier += FormatValue(pair.Value);
                
            }
            return tralier;
        }

      
        public string FormatDateTime(DateTime d)
        {
            string dayOfYear = d.DayOfYear.ToString("D3");

            string s = d.ToString("yyyy/" + dayOfYear + "-HH:mm:ss.fff");
            return s;
        }
        public string FormatValue(object value)
        {
          
            if (value is DateTime)
            {
                return FormatDateTime((DateTime)value);
            }
            else if(value is Enum)
            {
                return value.ToString();
            }
            else
            {
                return value.ToString().Replace(" ", "%");
            }
        }
        public IRestResponse ExecuteRequest()
        {
            this.restResponse = this.restClient.Execute(this.restRequest);
          
            return restResponse;
        }
     //   var cancellationTokenSource = new CancellationTokenSource();
        public IRestResponse ExecuteAsyncRequest(Action<IRestResponse> statusHandler)
        {


            this.restClient.ExecuteAsync(this.restRequest, statusHandler);

         //   this.restClient.ExecuteTaskAsync(this.restRequest, statusHandler);



            return restResponse;
        }
        public Task<IRestResponse> ExecuteTaskAsyncRequest()
        {
            this.cancelToken = new CancellationTokenSource();
        //    var cancellationTokenSource = new CancellationTokenSource();
   
            //this.restClient.ExecuteAsync(this.restRequest, statusHandler);

            Task<IRestResponse> task =   this.restClient.ExecuteTaskAsync(this.restRequest, this.cancelToken.Token);



            return task;
        }
        public void StopExecution()
        {
       //   this.restClient.
      
            this.restClient.Delete(this.restRequest);

           
        }

            public class regresResponse
        {
            [JsonProperty(PropertyName = "page")]
            public int page_num { get; set; }
            [JsonProperty(PropertyName = "per_page")]
            public int per_page { get; set; }
            [JsonProperty(PropertyName = "total")]
            public int total { get; set; }


        }
        public class DSNcomment
        {
            [JsonProperty(PropertyName = "postId")]
            public int post_id { get; set; }
            [JsonProperty(PropertyName = "id")]
            public int id { get; set; }
            [JsonProperty(PropertyName = "name")]
            public string name { get; set; }
            [JsonProperty(PropertyName = "email")]
            public string email { get; set; }
            [JsonProperty(PropertyName = "body")]
            public string body { get; set; }

        }
    }
}
