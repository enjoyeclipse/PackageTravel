using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PTSpider;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var spider = new SpiderExecuter();
            spider.Execute();
            Console.ReadLine();
        }
    }
}
