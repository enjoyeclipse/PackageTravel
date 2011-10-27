using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTSpider
{
   
    public class ChannelItemProperty
    {
        public int CategoryCode { get; set; }

        public ChannelItemProperty()
        { }

        public ChannelItemProperty(int category)
        {
            this.CategoryCode = category;
        }
    }

    public class ChannelItem
    {
        public string Url { get; set; }

        public ChannelItemProperty Properties { get; set; }

        public ChannelItem()
        { }

        public ChannelItem(string url)
        {
            this.Url = url;
        }

        public ChannelItem(string url, int categoryCode)
        {
            this.Url = url;
            this.Properties = new ChannelItemProperty(categoryCode);
        }
    }
    

}
