using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class ShopContract: BaseContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Addr { get; set; }

        [DataMember]
        public string Tel { get; set; }

        [DataMember]
        public string Bus { get; set; }

        [DataMember]
        public int CompositeScore { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int PerConsume { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public PositionContract Position { get; set; }

    }
}
