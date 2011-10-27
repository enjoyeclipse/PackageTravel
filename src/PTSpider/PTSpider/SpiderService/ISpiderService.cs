using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PTSpider.Model;

namespace PTSpider
{
    internal interface ISpiderService
    {
        void GetWebContent(Channel channel);
    }
}
