using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.TCP
{
    public class TcpState
    {
        public virtual void Transmit(TcpConnection connection, TcpOctetStream stream)
        {
        }

        public virtual void ActiveOpen(TcpConnection connection)
        {
        }

        public virtual void PassiveOpen(TcpConnection connection)
        {
        }

        public virtual void Close(TcpConnection connection)
        {
        }

        public virtual void Synchronize(TcpConnection connection)
        {
        }

        public virtual void Acknowledge(TcpConnection connection)
        {
        }

        public virtual void Send(TcpConnection connection)
        {
        }
    }
}
