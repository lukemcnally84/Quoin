using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Quoin.Specs
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_1_Equals_1()
        {
            int one = 1;
            Assert.AreEqual(1, one);
        }
    }
}
