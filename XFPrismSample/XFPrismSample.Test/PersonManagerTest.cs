using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFPrismSample.Models;

namespace XFPrismSample.Test
{
    [TestFixture]
    public class PersonManagerTest
    {
        [Test]
        public void PersonManagerテスト()
        {
            var man = new PersonManager();
            Assert.AreEqual(3, man.PeopleList.Count);
            Assert.AreEqual(1, man.PeopleList[0].Id);
            Assert.AreEqual("Ohtani", man.PeopleList[0].Name);
        }
    }
}
