using System;
using System.IO;
using System.Net;
using System.Text;

namespace PTCore
{
    public class HttpRequest
    {
        /// <summary>
        /// 抓取网页
        /// </summary>
        /// <param name="ieaddress"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string Request(string ieaddress, string encoding)
        {
            Stream ream;
            string restr;
            try
            {
                var hwr = (HttpWebRequest)WebRequest.Create(ieaddress);
                var httpresponse = (HttpWebResponse)hwr.GetResponse();
                ream = httpresponse.GetResponseStream();
                var sr = new StreamReader(ream, Encoding.GetEncoding(encoding));
                restr = sr.ReadToEnd();
                httpresponse.Close();
                ream.Close();
                ream.Dispose();
                sr.Close();
                sr.Dispose();
            }
            catch (Exception e)
            {
                restr = "False";
            }

            if (restr == string.Empty)
            {
                restr = "False";
            }

            return restr;
        }
    }
}