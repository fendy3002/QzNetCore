using System;
using Xunit;

namespace QzNetCoreTest
{
    public class UuidTest
    {
        [Fact]
        public void Test1()
        {
            string uuid = QzNetCore.Q._().Uuid();
            Assert.True(uuid.Length == 32);
        }
    }
}
