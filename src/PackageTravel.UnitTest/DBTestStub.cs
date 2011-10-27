using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Norm;
using NUnit.Framework;
using PTDomain;
using PTRepository;

namespace PackageTravel.UnitTest
{
    [DataContract]
    public class DBStub: BaseContract
    {
        [MongoIdentifier]
        public ObjectId Id { get; set; }


        [DataMember]
        public string Name { get; set; }
    }

    [TestFixture]
    public class DBTestStub
    {
        [Test]
        public void FirstDBTest()
        {
            using (var db = new MongoRepository<DBStub>())
            {
                db.Add(new DBStub() { Name = "test" });
            }
        }
    }
}
