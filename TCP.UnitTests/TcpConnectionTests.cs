using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ploeh.Samples.TCP.UnitTests
{
    public sealed class TcpConnectionTests
    {
        [Fact]
        public void ClosedActiveOpen()
        {
            var sut = new TcpConnection();
            sut.ActiveOpen();
            Assert.Equal(TcpEstablished.Instance, sut.State);
        }
    }
}
