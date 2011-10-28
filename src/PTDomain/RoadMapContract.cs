using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class RoadMapContract
    {
        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string Des { get; set; }

        [DataMember]
        public bool Visite { get; set; }

        [DataMember]
        public RoadMapContract Prev { get; set; }

        public RoadMapContract()
        {
            
        }
        public RoadMapContract(string source, string des)
        {
            Source = source;
            Des = des;
        }
    }
}
