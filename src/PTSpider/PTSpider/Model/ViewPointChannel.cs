using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTSpider.Model
{
    public class ViewPointChannel: Channel
    {
        public override void Init()
        {
            for (int i = 0; i < 311; ++i )
            {
                ChannelItems.Add(new ChannelItem(string.Format("http://www.mafengwo.cn/lushu/info.php?rbook_id={0}&index_id=2&type_id=78&poi_type_id=3", i)));
            
            }
                
        }
    }
}
