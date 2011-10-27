using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class PositionContract : BaseContract
    {
        public PositionContract()
        {
            
        }

        public PositionContract(string lng, string lat)
        {
            Lng = lng;
            Lat = lat;
        }

        [DataMember]
        public string Lng { get; set; }

        [DataMember]
        public string Lat { get; set; }
    }
}
