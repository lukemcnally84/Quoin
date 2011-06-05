using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Quoin.Tests
{
    public class Class1
    {
        [Fact]
        public void Test_1_Equals_1()
        {
            int one = 1;
            Assert.Equal<int>(1, one);
        }
    }
}
