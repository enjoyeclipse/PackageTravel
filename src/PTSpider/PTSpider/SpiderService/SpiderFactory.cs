using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PTSpider.SpiderService;

namespace PTSpider
{
    internal static class SpiderFactory
    {
        internal enum SiteType
        {
            DianPing = 1,
            MafengWo
        };

        public static ISpiderService Create(SiteType siteType)
        {
            ISpiderService spider;
            switch (siteType)
            {
                case SiteType.DianPing:
                    spider = new DianpingService();
                    break;

                case SiteType.MafengWo:
                    spider = new MafengWoService();
                    break;

                default:
                    throw new Exception("Unsupport Spider Type");
            }

            return spider;
        }
    }
}
