using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Common.Logging;
using PTCore;
using PTDomain;
using PTSpider.Model;

namespace PTSpider
{
    internal class DianpingService : ISpiderService
    {
        
        //private ShopService _shopService;
        //private ShopSourceService _shopSourceService;
        //private readonly TagsService _tagsService;

        private readonly ILog _logger = LogManager.GetCurrentClassLogger();

        public DianpingService() {}

        //public Web_DianPing_Services(ShopSourceService shopSourceService,
        //                             ShopService shopRepository,
        //                             TagsService tagsService)
        //{
        //    //_shopService = shopRepository;
        //    //_shopSourceService = shopSourceService;

        //    //_tagsService = tagsService;
        //}

        public void GetWebContent(Channel channel)
        {
            _logger.Debug("更新点评网的商品:");

            int count = 0;

            var foodChannel = channel as FoodChannel;
            foreach (var item in foodChannel.ChannelItems)
            {
                count += GetWebContent(item);
            }

            _logger.Debug("点评网商品更新完成,此次共更新条数: " + count + " 条,请敲回车结束");
        }

        private int GetWebContent(ChannelItem item)
        {
            var url = item.Url;
            int count = 0;
            string htmlCode = HttpRequest.Request(url, "UTF-8");
            int allPage = GetAllPageCount(htmlCode);
            for (int i = 1; i < allPage + 1; i++)
            {
                string linkurl = url.Substring(0, url.LastIndexOf("/")) + "p" + i + url.Substring(url.LastIndexOf("/"), url.Length - (url.LastIndexOf("/")));
                count += SubListContent(linkurl, item.Properties.CategoryCode);
            }
            return count;
        }

        public int SubListContent(string url, int categoryCode)
        {
            int count = 0;
            Console.WriteLine("解析的URL是:" + url);
            string htmlcode = HttpRequest.Request(url, "UTF-8");
            if (htmlcode == "False")
                return 0;
            if (htmlcode.IndexOf("shopIDs:") - 5 - (htmlcode.IndexOf("shopPOIs:	[") + 11) < 0)
                return 0;
            htmlcode = htmlcode.Substring(htmlcode.IndexOf("shopPOIs:	[") + 11, htmlcode.IndexOf("shopIDs:") - 5 - (htmlcode.IndexOf("shopPOIs:	[") + 11)) + "},";
            int listCount = new Regex("}},").Matches(htmlcode).Count;
            htmlcode = htmlcode.Replace("}},", "^");
            for (int i = 0; i < listCount; i++)
            {
                string listcode = htmlcode.Split('^')[i];
                count += 1;
                try
                {
                    string ieaddress = "http://www.dianping.com/shop/" + listcode.Substring(listcode.IndexOf("\"id\":") + 5, listcode.IndexOf(",\"ico\"") - (listcode.IndexOf("\"id\":") + 5));
                   // AddOrUpdateShop(ieaddress, categoryCode);
                }
                catch (Exception e)
                {
                    _logger.Debug(e.Message);
                }
            }
            return count;
        }

        public void AddOrUpdateShop(string ieaddress, int categoryCode)
        {
            //var site = _shopSourceService.Get(f => f.Url == ieaddress);
            var details = GetShopDetail(ieaddress);
            //if (site.Count > 0)
            //{
            //    //修改店铺
            //    var shop = _shopService.Get(site[0].ShopId);
            //    UpdateShopContract(categoryCode, shop, details, jsonTags);
            //    //_shopService.Update(shop);
            //    Console.WriteLine("已修改:" + details["shopname"]);
            //}
            //else
            //{
            //    //添加店铺
            //    var shop = new ShopContract();
            //    UpdateShopContract(categoryCode, shop, details, jsonTags);
            //    //shop = _shopService.Add(shop);
            //    //_shopSourceService.Add(ieaddress, Channel.ChannelName, shop.Id);
            //    Console.WriteLine("已成功添加:" + details["shopname"]);
            //}
        }

        private void UpdateShopContract(int categoryCode, ShopContract shop, IDictionary<string, string> details, string jsonTags)
        {
            string value;
            if (details.TryGetValue("shopname", out value))
            {
                shop.Name = value;
            }

            if (details.TryGetValue("address", out value))
            {
                shop.Addr = value;
            }

            if (details.TryGetValue("phone", out value))
            {
                shop.Tel = value;
            }

            if (details.TryGetValue("bus", out value))
            {
                shop.Bus = value;
            }

            if (details.TryGetValue("compositeScore", out value))
            {
                shop.CompositeScore = int.Parse(value);
            }

            if (details.TryGetValue("description", out value))
            {
                shop.Description = value;
            }

            if (details.TryGetValue("perConsume", out value))
            {
                shop.PerConsume = int.Parse(value);
            }

            shop.Type = categoryCode;
            //shop.TypeStr = TypeMapping.GetName(categoryCode);
        }

     
        public int GetAllPageCount(string html)
        {
            int end = html.IndexOf("<span class=\"iup\"></span>");
            if (end == -1)
            {
                return 1;
            }

            try
            {
                string pageCode = html.Substring(html.IndexOf("<div class=\"Pages\">"), end - html.IndexOf("<div class=\"Pages\">"));

                //去掉最后一个<a href="
                pageCode = pageCode.Substring(0, pageCode.LastIndexOf("<a href=\""));
                //取出最后一个<a href="
                pageCode = pageCode.Substring(pageCode.LastIndexOf("<a href=\""), pageCode.Length - (pageCode.LastIndexOf("<a href=\"")));
                return int.Parse(pageCode.Substring(pageCode.IndexOf(">") + 1, pageCode.IndexOf("</") - (pageCode.IndexOf(">") + 1)));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public Dictionary<string, string> GetShopDetail(string ieaddress)
        {
            var details = new Dictionary<string, string>();
            string result = HttpRequest.Request(ieaddress, "UTF-8");
            string shopname = string.Empty;

            if ((result.IndexOf("shopName:   '") != -1) && (result.IndexOf("userID:") != -1))
            {
                shopname = result.Substring(result.IndexOf("shopName:   '") + 13, result.IndexOf("userID:") - (result.IndexOf("shopName:   '") + 13));
                shopname = shopname.Substring(0, shopname.IndexOf("',"));
                details.Add("shopname", shopname);
            }
            string area = string.Empty;
            if ((result.IndexOf("<span class=\"region\" itemprop=\"locality region\">") != -1) && (result.IndexOf("</span></a><span itemprop=\"street-address\">") != -1))
            {
                area = result.Substring(result.IndexOf("<span class=\"region\" itemprop=\"locality region\">") + 48, result.IndexOf("</span></a><span itemprop=\"street-address\">") - (result.IndexOf("<span class=\"region\" itemprop=\"locality region\">") + 48));
                details.Add("area", area);
            }
            string address = string.Empty;
            if ((result.IndexOf("</span></a><span itemprop=\"street-address\">") != -1) && (result.LastIndexOf("</span></dd></dl><dl><dt>") != -1))
            {
                address = result.Substring(result.IndexOf("</span></a><span itemprop=\"street-address\">") + 43, result.LastIndexOf("</span></dd></dl><dl><dt>") - (result.IndexOf("</span></a><span itemprop=\"street-address\">") + 43));
                if (address.IndexOf("</span>") != -1)
                {
                    address = address.Substring(0, address.IndexOf("</span>"));
                    if (address.IndexOf(area) != -1)
                    {
                        address = area + address;
                    }
                }
                details.Add("address", address);
            }

            string phone = string.Empty;
            if ((result.IndexOf("<strong itemprop=\"tel\">") != -1) && (result.IndexOf("</strong></dd></dl><dl><dt>") != -1))
            {
                phone = result.Substring(result.IndexOf("<strong itemprop=\"tel\">") + 23, result.IndexOf("</strong></dd></dl><dl><dt>") - (result.IndexOf("<strong itemprop=\"tel\">") + 23));
                if (phone.IndexOf("&nbsp;") != -1)
                {
                    phone = phone.Split('&')[0];
                }
                details.Add("phone", phone);
            }

            string perCosume = string.Empty;
            if ((result.IndexOf("人均</dt><dd><span class=\"Price\">¥</span>") != -1) && (result.IndexOf("</dd></dl></div><div class=\"desc-list\">") != -1))
            {
                perCosume = result.Substring(result.IndexOf("人均</dt><dd><span class=\"Price\">¥</span>") + 39, result.IndexOf("</dd></dl></div><div class=\"desc-list\">") - (result.IndexOf("人均</dt><dd><span class=\"Price\">¥</span>") + 39));
                details.Add("perConsume", perCosume);
            }

            string descption = string.Empty;
            if ((result.IndexOf("商户描述:</dt><dd>")) != -1 && (result.LastIndexOf("</dd></dl><dl class=\"J_tags-fold-wrap\"><dt>") != -1))
            {
                descption = result.Substring(result.IndexOf("商户描述:</dt><dd>") + 14, result.LastIndexOf("</dd></dl><dl class=\"J_tags-fold-wrap\"><dt>") - (result.IndexOf("商户描述:</dt><dd>") + 14));
                if (descption.IndexOf("</dd></dl>") != -1)
                    descption = descption.Substring(0, descption.IndexOf("</dd></dl>"));
                details.Add("description", descption);
            }
            else
            {
                string a = ieaddress;
            }

            string bus = string.Empty;
            if ((result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_full-cont\">") != -1) && (result.LastIndexOf("</span><span class=\"link-fn fn-report\">") != -1))
            {
                bus = result.Substring(result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_full-cont\">") + 85, result.LastIndexOf("</span><span class=\"link-fn fn-report\">") - (result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_full-cont\">") + 85));
                details.Add("bus", bus);
            }
            else if ((result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_brief-cont\">") != -1) && (result.LastIndexOf("</span><span class=\"link-fn fn-report\">") != -1))
            {
                bus = result.Substring(result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_brief-cont\">") + 86, result.LastIndexOf("</span><span class=\"link-fn fn-report\">") - (result.IndexOf("公交信息:</dt><dd class=\"J_info-edit-wrap\" data-info-type=\"pt\"><span class=\"J_brief-cont\">") + 86));
                if (bus.IndexOf("</span>") != -1)
                {
                    bus = bus.Split('<')[0];
                }
                details.Add("bus", bus);
            }

            string reputationScore = string.Empty;//口味分
            string environmentScore = string.Empty;//环境分
            string serviceScore = string.Empty;//服务分
            if ((result.IndexOf("环境:</dt><dd><span class=\"progress-bar\">") != -1) && (result.IndexOf("服务:</dt><dd><span class=\"progress-bar\">") != -1))
            {
                if (result.IndexOf("口味:</dt><dd><span class=\"progress-bar\">") != -1)
                {
                    reputationScore = result.Substring(result.IndexOf("口味:</dt><dd><span class=\"progress-bar\">") + 39, result.IndexOf("环境:</dt><dd><span class=\"progress-bar\">") - (result.IndexOf("口味:</dt><dd><span class=\"progress-bar\">") + 39));
                }
                else
                {
                    reputationScore = result.Substring(result.IndexOf("产品:</dt><dd><span class=\"progress-bar\">") + 39, result.IndexOf("环境:</dt><dd><span class=\"progress-bar\">") - (result.IndexOf("产品:</dt><dd><span class=\"progress-bar\">") + 39));
                }

                reputationScore = reputationScore.Substring(reputationScore.IndexOf(">") + 1, reputationScore.IndexOf("%</span>") - (reputationScore.IndexOf(">") + 1));
                environmentScore = result.Substring(result.IndexOf("环境:</dt><dd><span class=\"progress-bar\">") + 39, result.IndexOf("服务:</dt><dd><span class=\"progress-bar\">") - (result.IndexOf("环境:</dt><dd><span class=\"progress-bar\">") + 39));
                environmentScore = environmentScore.Substring(environmentScore.IndexOf(">") + 1, environmentScore.IndexOf("%</span>") - (environmentScore.IndexOf(">") + 1));
                serviceScore = result.Substring(result.IndexOf("服务:</dt><dd><span class=\"progress-bar\">") + 39, result.LastIndexOf("</span><em class=\"progress-value\">") - (result.IndexOf("服务:</dt><dd><span class=\"progress-bar\">") + 39));
                serviceScore = serviceScore.Substring(serviceScore.IndexOf(">") + 1, serviceScore.IndexOf("%</span>") - (serviceScore.IndexOf(">") + 1));
                details.Add("reputationScore", reputationScore);
                details.Add("environmentScore", environmentScore);
                details.Add("serviceScore", serviceScore);
            }

            int compositeScore;
            if (!string.IsNullOrEmpty(reputationScore) && !string.IsNullOrEmpty(environmentScore) && !string.IsNullOrEmpty(serviceScore))
            {
                compositeScore = (int.Parse(reputationScore) + int.Parse(serviceScore) + int.Parse(environmentScore)) / 3;
                details.Add("compositeScore", compositeScore.ToString());
            }
            return details;
        }

        
    }
    
}
