using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTSpider.Model
{
    public class FoodChannel: Channel
    {
        public override void Init()
        {
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r42/g10g473r42", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r44/g10g473r44", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r43/g10g473r43", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r45/g10g473r45", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r46/g10g473r46", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r47/g10g473r47", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r48/g10g473r48", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r5742/g10g473r5742", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r5741/g10g473r5741", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g473r50/g10g473r50", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g474r0n1/g10g474", FOOD_CATEGORY_CODE));
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g1478r0n1/g10g1478", FOOD_CATEGORY_CODE));

            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r42n1/g10g481r42", FOOD_CATEGORY_CODE)); // 火锅渝中区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r43n1/g10g481r43", FOOD_CATEGORY_CODE)); // 火锅沙坪坝区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r44n1/g10g481r44", FOOD_CATEGORY_CODE)); // 火锅江北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r45n1/g10g481r45", FOOD_CATEGORY_CODE)); //火锅渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r46n1/g10g481r46", FOOD_CATEGORY_CODE)); // 火锅南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r46n1/g10g481r47", FOOD_CATEGORY_CODE)); // 火锅九龙坡区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r46n1/g10g481r48", FOOD_CATEGORY_CODE)); // 火锅大渡口区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r5742n1/g10g481r5742", FOOD_CATEGORY_CODE)); // 火锅巴南区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g481r5741n1/g10g481r5741", FOOD_CATEGORY_CODE)); // 火锅北碚区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g10r50n1/g10r50", FOOD_CATEGORY_CODE)); // 火锅近郊

            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g482", FOOD_CATEGORY_CODE)); // 
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g483n1/g10g483", FOOD_CATEGORY_CODE)); // 海鲜
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g493n1/g10g493", FOOD_CATEGORY_CODE)); // 日韩料理
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g496n1/g10g496", FOOD_CATEGORY_CODE)); // 西餐
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g1476n1/g10g1476", FOOD_CATEGORY_CODE)); // 自助餐
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g4283n1/g10g489g4283", FOOD_CATEGORY_CODE)); // 面包蛋糕
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g4285n1/g10g489g4285", FOOD_CATEGORY_CODE)); // 甜品饮料
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r42/g10g485r42", FOOD_CATEGORY_CODE)); // 小吃渝中区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r43", FOOD_CATEGORY_CODE)); // 小吃沙坪坝
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r44", FOOD_CATEGORY_CODE)); // 小吃江北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r45", FOOD_CATEGORY_CODE)); // 小吃渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r46", FOOD_CATEGORY_CODE)); // 小吃南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r47", FOOD_CATEGORY_CODE)); // 小吃九龙烧烤坡区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485n1r43/g10g485r48", FOOD_CATEGORY_CODE)); // 小吃大渡口区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485r5742n1/g10g485r5742", FOOD_CATEGORY_CODE)); // 小吃巴南区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485r50n1/g10g485r50", FOOD_CATEGORY_CODE)); // 小吃北碚
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g485r50n1/g10g485r50", FOOD_CATEGORY_CODE)); // 小吃近郊

            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r42/g10g480r42", FOOD_CATEGORY_CODE)); // 其他渝中区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r43/g10g480r43", FOOD_CATEGORY_CODE)); // 其他沙坪坝
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r44/g10g480r44", FOOD_CATEGORY_CODE)); // 其他江北区 
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r45/g10g480r45", FOOD_CATEGORY_CODE)); // 其他渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r46/g10g480r46", FOOD_CATEGORY_CODE)); // 其他南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r47/g10g480r47", FOOD_CATEGORY_CODE)); // 其他九龙坡区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r48/g10g480r48", FOOD_CATEGORY_CODE)); // 其他大渡口区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r5742/g10g480r5742", FOOD_CATEGORY_CODE)); // 其他巴南区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r5741/g10g480r5741", FOOD_CATEGORY_CODE)); // 其他北碚区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/10/g480n1r50/g10g480r50", FOOD_CATEGORY_CODE)); // 其他近郊

            // 休闲娱乐
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r42n1/g30r42", PLAY_CATEGORY_CODE)); // 休闲娱乐渝中区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r43n1/g30r43", PLAY_CATEGORY_CODE)); // 休闲娱乐沙坪坝区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r44n1/g30r44", PLAY_CATEGORY_CODE)); // 休闲娱乐江北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r45n1/g30r45", PLAY_CATEGORY_CODE)); // 休闲娱乐渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r46n1/g30r46", PLAY_CATEGORY_CODE)); // 休闲娱乐南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r47n1/g30r47", PLAY_CATEGORY_CODE)); // 休闲娱乐九龙坡
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r48n1/g30r48", PLAY_CATEGORY_CODE)); // 休闲娱乐大渡口
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r5742n1/g30r5742", PLAY_CATEGORY_CODE)); // 休闲娱乐北碚
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/30/g30r50n1/g30r50", PLAY_CATEGORY_CODE)); // 休闲娱乐近郊*/

            // 生活服务
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r43n1/g80r43", LIVE_CATEGORY_CODE));// 沙坪坝区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r44n1/g80r44", LIVE_CATEGORY_CODE));// 江北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r45n1/g80r45", LIVE_CATEGORY_CODE));// 渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r46n1/g80r46", LIVE_CATEGORY_CODE));// 南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r47n1/g80r47", LIVE_CATEGORY_CODE));// 九龙坡区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r48n1/g80r48", LIVE_CATEGORY_CODE));// 大渡口区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r5742n1/g80r5742", LIVE_CATEGORY_CODE));// 巴南区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r5741n1/g80r5741", LIVE_CATEGORY_CODE));// 北碚区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/80/g80r50n1/g80r50", LIVE_CATEGORY_CODE));// 近郊

            //购物
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r42/g20r42", SHOPPING_CATEGORY_CODE));//渝中区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r43/g20r43", SHOPPING_CATEGORY_CODE));//沙坪坝区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r44/g20r44", SHOPPING_CATEGORY_CODE));//江北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r45/g20r45", SHOPPING_CATEGORY_CODE));//渝北区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r45/g20r46", SHOPPING_CATEGORY_CODE));//南岸区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r47/g20r47", SHOPPING_CATEGORY_CODE));//九龙坡区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r48/g20r48", SHOPPING_CATEGORY_CODE));//大渡口区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r5742/g20r5742", SHOPPING_CATEGORY_CODE));//巴南区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r5741/g20r5741", SHOPPING_CATEGORY_CODE));//北碚区
            ChannelItems.Add(new ChannelItem("http://www.dianping.com/search/category/9/20/g20r50/g20r50", SHOPPING_CATEGORY_CODE));//近郊
        }
    }
}
