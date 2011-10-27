using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class ViewPointContract: BaseContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public int PerConsume { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public PositionContract Position { get; set; }
    }
}
