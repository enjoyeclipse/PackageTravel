using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace PTService
{
    public class WeatherPackageService: BasePackageService
    {
        public void Process()
        {
            HttpWebRequest GWP_Request; HttpWebResponse GWP_Response = null;

            XmlDocument GWP_XMLdoc = null;

            try
            {

                GWP_Request = (HttpWebRequest)WebRequest.Create(string.Format("http://webservice.webxml.com.cn/WebServices/WeatherWS.asmx/getRegionProvince"));

                GWP_Request.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.8.1.4) Gecko/20070515 Firefox/2.0.0.4";

                GWP_Response = (HttpWebResponse)GWP_Request.GetResponse();

                GWP_XMLdoc = new XmlDocument();

                GWP_XMLdoc.Load(GWP_Response.GetResponseStream());

            }
            catch (Exception ex)
            {
            }

            GWP_Response.Close(); 
   
        }
    }
}
