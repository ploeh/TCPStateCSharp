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
            var actual = sut.ActiveOpen();
            Assert.Equal(TcpEstablished.Instance, actual.State);
        }

        [Fact]
        public void ClosedPassiveOpen()
        {
            var sut = new TcpConnection();
            var actual = sut.PassiveOpen();
            Assert.Equal(TcpListen.Instance, actual.State);
        }

        [Fact]
        public void EstablishedClose()
        {
            var sut = new TcpConnection();
            var actual = sut.ActiveOpen().Close();
            Assert.Equal(TcpListen.Instance, actual.State);
        }

        [Fact]
        public void EstablishedTransmit()
        {
            var spy = new SpyConnection();
            var expected = new TcpOctetStream();

            var actual = TcpEstablished.Instance.Transmit(spy, expected);

            Assert.Contains(expected, spy);
        }

        [Fact]
        public void ListenSend()
        {
            var sut = new TcpConnection();
            var actual = sut.PassiveOpen().Send();
            Assert.Equal(TcpEstablished.Instance, actual.State);
        }
    }
}
