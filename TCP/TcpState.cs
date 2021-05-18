using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.TCP
{
    public class TcpState
    {
        public virtual TcpState Transmit(TcpConnection connection, TcpOctetStream stream)
        {
            return this;
        }

        public virtual TcpState ActiveOpen(TcpConnection connection)
        {
            return this;
        }

        public virtual TcpState PassiveOpen(TcpConnection connection)
        {
            return this;
        }

        public virtual TcpState Close(TcpConnection connection)
        {
            return this;
        }

        public virtual TcpState Synchronize(TcpConnection connection)
        {
            return this;
        }

        public virtual TcpState Acknowledge(TcpConnection connection)
        {
            return this;
        }

        public virtual TcpState Send(TcpConnection connection)
        {
            return this;
        }
    }
}
