using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTSpider.Model
{
    public abstract class Channel
    {
        public const int FOOD_CATEGORY_CODE = 10030;
        public const int PLAY_CATEGORY_CODE = 10031;
        public const int LIVE_CATEGORY_CODE = 10032;
        public const int SHOPPING_CATEGORY_CODE = 10033;

        public abstract void Init();

        private readonly List<ChannelItem> channelItems = new List<ChannelItem>();

        public List<string> Urls
        {
            get
            {
                var urls = new List<string>();
                var items = ChannelItems;
                foreach (var item in items)
                {
                    urls.Add(item.Url);
                }

                return urls;
            }
        }
        
        public List<ChannelItem> ChannelItems
        {
            get
            {
                return channelItems;
            }
        }

        public int CityCode { get; set; }
    }
}