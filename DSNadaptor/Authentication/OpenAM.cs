using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net.Http;
using System.IO;

namespace DSNadaptor
{

        class OpenAM
    {




        public string username { get; set; }
        public string password { get; set; }
        public string domain { get; set; }
        public string cookieURI { get; set; }
        public string authenticationURI { get; set; }
        public string defaultCookieName { get; set; }
        public int tokenHourValidity { get; set; }
        public Cookie CurrentCookie { get; set; }

        public List<string> errors { get; set; }
   
        public DateTime tokenDateTime { get; set; }
        public OpenAM(string user,string pass, string cookieURI,string auURI,string domain,string defaultCookieName,int tokenHoursValidity) //TODO add mechanism to genreate new token after 12 hours timeout
        {

            this.username = user;
            this.password = pass;
            this.cookieURI = cookieURI;
            this.authenticationURI = auURI;
            this.domain = domain;
            this.defaultCookieName = defaultCookieName;
            this.tokenHourValidity = tokenHoursValidity;
            this.CurrentCookie = null;
            errors = new List<string>();
         //   this.uri = string.Format(@"http://{0}/{1}/identity/authenticate?username={3}&password={4}",this.hostAdd,this.uri,this.username,this.password);
        }
        public bool Authenticate(ref Cookie cookie)
        {
            errors = new List<string>();
            if (this.CurrentCookie!=null && istokentimevalid())
            {
                cookie = this.CurrentCookie;
                return true;
            }
            string cookieName = "";
            string tokenID = "";
            
            if(!getCookieName( ref cookieName))
            {
                errors.Add("Using default cookie name : "+this.defaultCookieName);
                cookieName = this.defaultCookieName;

               
            }
            if (!getTokenID(ref tokenID))
            {
                errors.Add("Couldn't get token using credentials, trying to fetch from Chrome");
                if (!getTokenIDFromChrome(ref tokenID, cookieName,this.domain))
                {
                    
                    return false;
                }
            }
            this.tokenDateTime = DateTime.Now;
                cookie = new Cookie(cookieName, tokenID);
            cookie.Domain = this.domain;
            this.CurrentCookie = cookie;
            return true;
          // 
        }
        private void AddError(HttpStatusCode code, string error)
        {
            this.errors.Add(code.ToString()+" - "+ error);        
        }

        public bool getCookieName(ref string CookieName)
        {
            var client = new RestClient(this.cookieURI);
            var request = new RestRequest("/", Method.GET);
            var queryResult = client.Execute(request);
            if (queryResult.StatusCode == HttpStatusCode.OK)
            {
                CookieName = queryResult.Content.Trim('\n').Split('=')[1];
                return true;
            }
            else
            {
                AddError(queryResult.StatusCode, "Failed to fetch cookie name");
                return false;
            }

        }
        public bool getTokenID(ref string TokenID)
        {
            var client = new RestClient(this.authenticationURI);
            var request = new RestRequest("/", Method.POST);
            request.AddParameter("username", this.username);
            request.AddParameter("password", this.password);
            IRestResponse response = client.Execute(request);
           // var queryResult = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
          
            if (response.StatusCode == HttpStatusCode.OK )
            {

                TokenID = response.Content.Trim('\n').Split('=')[1];
                return true;
            }
            else
            {
                AddError(response.StatusCode, "Couldn't fetch TokenID");
                return false;
            }
            
        }
        public bool getTokenIDFromChrome(ref string tokenID,string cookieName,string domain)
        {
            if (!Chrome.GetCookie_Chrome(domain, cookieName, ref tokenID))
            {
                AddError(HttpStatusCode.Unauthorized, "Couldn't fetch cookie from Chrome");
                return false;
            }
            else return true;
        }
        public class TokenResponse
        {
            [JsonProperty(PropertyName = "token.id")]
            public string tokenid { get; set; }
        }

     
        public bool istokentimevalid()
        {
            TimeSpan diff = DateTime.Now.Subtract(this.tokenDateTime);
            if (diff.TotalHours >this.tokenHourValidity)
            {
                return false;
            }
            return true;
        }
    }
}
