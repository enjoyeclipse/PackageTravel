using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class PhotoContract : BaseContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public PositionContract Position { get; set; }
    }
}
