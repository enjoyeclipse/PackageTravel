using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PTDomain
{
    [DataContract]
    public class GalleryContract : BaseContract
    {
        public List<PhotoContract> Photos { get; set; }
    }
}
