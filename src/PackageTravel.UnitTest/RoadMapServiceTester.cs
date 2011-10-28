using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PTService;

namespace PackageTravel.UnitTest
{
    [TestFixture]
    public class RoadMapServiceTester
    {
        [Test]
        public void Find_Test()
        {
            var roadMapService = new RoadMapService();
            roadMapService.Find("重庆", "九寨沟");
        }
    }
}
