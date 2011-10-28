using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PTDomain;

namespace PTService
{
    public class RoadMapService
    {
        List<RoadMapContract> roads = new List<RoadMapContract>()
                            {
                                new RoadMapContract("重庆", "南川"),
                                new RoadMapContract("重庆", "成都"),  
                                new RoadMapContract("南川", "成都"),
                                new RoadMapContract("成都", "汶川"),
                                new RoadMapContract("汶川", "松潘"),
                                new RoadMapContract("松潘", "九寨沟")
                            };

        public List<RoadMapContract> Find(string source, string des)
        {
            var results = new List<RoadMapContract>();

            var starts = roads.FindAll(f => f.Source == source);
           
            var targets = new List<RoadMapContract>();
            foreach (var start in starts)
            {
                DFS(start, des, targets);
            }
            
            foreach (var target in targets)
            {
                var temp = target;
                while (temp != null)
                {    
                    Console.WriteLine("From:" + temp.Source + "Des:" + temp.Des);
                    if (temp.Source == source)
                    {
                        break;
                    }

                    temp = temp.Prev;
                }    
            }
            return results;
        }


        void DFS(RoadMapContract map, string des, ICollection<RoadMapContract> results)
        {
            map.Visite = true;
            if (map.Des == des)
            {
                results.Add(map);
                return;         
            }

            foreach (var road in roads)
            {
                if (road.Source == map.Des)
                {
                    road.Prev = map;
                }

                if (!road.Visite)
                {
                    DFS(road, des, results);                   
                }
            }
        }
    }
}
