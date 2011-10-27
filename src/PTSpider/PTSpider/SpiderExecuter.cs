using PTSpider.Model;

namespace PTSpider
{
    public class SpiderExecuter
    {
        public void Execute()
        {
            var channel = new ViewPointChannel();
            ISpiderService spiderService = SpiderFactory.Create(SpiderFactory.SiteType.MafengWo);
            spiderService.GetWebContent(channel);
        }
    }
}
