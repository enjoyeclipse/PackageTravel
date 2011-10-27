using System;
using System.Text.RegularExpressions;
using Common.Logging;
using PTCore;
using PTSpider.Model;

namespace PTSpider.SpiderService
{
    internal class MafengWoService : ISpiderService
    {
        private readonly ILog _logger = LogManager.GetCurrentClassLogger();

        public void GetWebContent(Channel channel)
        {
            
            _logger.Debug("更新马蜂窝的攻略:");

            channel.Init();

            int count = 0;

            var viewPointChannel = channel as ViewPointChannel;
            foreach (var item in viewPointChannel.ChannelItems)
            {
                count += GetWebContent(item);
            }

            _logger.Debug("更新马蜂窝的攻略,此次共更新条数: " + count + " 条,请敲回车结束");
        }

        private int GetWebContent(ChannelItem item)
        {
            var url = item.Url;
            int count = 0;
            string htmlCode = HttpRequest.Request(url, "UTF-8");


            int startIndex = htmlCode.IndexOf("<ul id=\"pnl_content\">");
           
            if (startIndex != -1 && htmlCode.IndexOf("</ul>", startIndex) != -1)
            {
                int endIndex = htmlCode.IndexOf("</ul>", startIndex);

                var litag = htmlCode.Substring(startIndex, endIndex - startIndex);
                string pattern = @"(?<=<li>)[\s\S]*?(?=</li>)";
                foreach (Match mx in Regex.Matches(litag, pattern))
                {
                    // 获取景点名字
                    string pattern2 = @"(?<=<strong>)[\s\S]*?(?=</strong>)";
                    var nameMx = Regex.Match(mx.Value, pattern2);
                    Console.WriteLine(nameMx.Value);

                    // 获取景点地址
                    string pattern3 = @"(?<=<dd>)[\s\S]*?(?=</dd>)";
                    var addressMx = Regex.Match(mx.Value, pattern3);
                    Console.WriteLine(addressMx.Value);

                    count++;
                }
            }

            return count;
        }
    }
}
