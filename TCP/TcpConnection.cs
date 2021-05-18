using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.TCP
{
    public class TcpConnection
    {
        public TcpState State { get; internal set; }

        public TcpConnection()
        {
            State = TcpClosed.Instance;
        }

        public TcpConnection ActiveOpen()
        {
            State.ActiveOpen(this);
            return this;
        }

        public TcpConnection PassiveOpen()
        {
            State.PassiveOpen(this);
            return this;
        }

        public TcpConnection Close()
        {
            State.Close(this);
            return this;
        }

        public TcpConnection Send()
        {
            State.Send(this);
            return this;
        }

        public TcpConnection Acknowledge()
        {
            State.Acknowledge(this);
            return this;
        }

        public TcpConnection Synchronize()
        {
            State.Synchronize(this);
            return this;
        }

        public virtual TcpConnection ProcessOctet(TcpOctetStream stream)
        {
            return this;
        }
    }
}
