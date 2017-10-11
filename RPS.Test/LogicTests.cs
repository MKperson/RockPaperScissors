using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Rps.Library;

namespace RPS.Test
{
    class LogicTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void Test1()
        {
            
        }
    }
}
