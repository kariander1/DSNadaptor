using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace DSNadaptor
{

    class GETsfduQuery : QuerySession
    {
    //    string[] fields = new string[] { "dataTypes", "timeType", "startTime", "endTime", "dss", "dataFrom","" };
        public string queryServer { get; set; }
        public string scid { get; set; }
        public RestSharp.Method Method { get; set; }
        public Hashtable parameters { get; set; }
        public GETsfduQuery(string server,int requestTO,string baseURI, bool UseProxy, string proxy_address, int proxy_port, string scid= "147", string queryServer= "Gif_spil1", Cookie cookie = null,DateTime startTime = new DateTime(), DateTime endTime = new DateTime(),string dss=null) : base(server, requestTO,baseURI,UseProxy,proxy_address,proxy_port,cookie) //TODO configuration
        {
            bool manual = false;
            this.scid = scid;
            this.queryServer = queryServer;
            this.Method = RestSharp.Method.GET;

            parameters = new Hashtable();
            parameters.Add("dataTypes", "dsn_turbo_decd_crc_pass"); //TODO Configuration

            //            parameters.Add("dataTypes", "dsn_turbo_decd_crc_pass,dsn_turbo_decd_crc_fail"); //TODO Configuration
            parameters.Add("timeType", "ERT");


            if (startTime == new DateTime())
            {
                parameters.Add("startTime", @"NOW");
            //    parameters.Add("startTime", @"2019/043-16:40:33.000");
            }
            else
            {
                parameters.Add("startTime", base.FormatDateTime(startTime));
                manual = true;
            }

            if (endTime == new DateTime())
                parameters.Add("endTime", @"FOREVER");
            else
            {
                parameters.Add("endTime", base.FormatDateTime(endTime));
                manual = true;
            }

            if(dss!=null)
            {
                parameters.Add("dss", dss);
            }
            if(!manual)
                parameters.Add("queryName", "SIL_FOREVER_"+DateTime.UtcNow.Ticks);
            else
                parameters.Add("queryName", "SIL_MAN" + DateTime.UtcNow.Ticks);

            parameters.Add("requesterName", "SIL_DSN_adaptor");
            if (!manual)
            {
                parameters.Add("ancillary", "STATUS");
            }
            else
            {
                parameters.Add("ancillary", "NONE");
            }

            string uri = Build_URI();
            base.restRequest = new RestSharp.RestRequest(uri, this.Method);

        }   
        public virtual string Build_URI()
        {
            return base.BaseURI+ string.Format(@"{0}/{1}/query/sfdus", this.scid,this.queryServer)+base.FormatParameters(this.parameters);
        }
        public class GETsfduResponse
        {
            [JsonProperty(PropertyName = "page")]
            public int page_num { get; set; }
            [JsonProperty(PropertyName = "per_page")]
            public int per_page { get; set; }
            [JsonProperty(PropertyName = "total")]
            public int total { get; set; }


        }
    }


}
