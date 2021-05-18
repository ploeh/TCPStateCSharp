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

        private TcpConnection(TcpState state)
        {
            State = state;
        }

        public TcpConnection ActiveOpen()
        {
            return new TcpConnection(State.ActiveOpen(this));
        }

        public TcpConnection PassiveOpen()
        {
            return new TcpConnection(State.PassiveOpen(this));
        }

        public TcpConnection Close()
        {
            return new TcpConnection(State.Close(this));
        }

        public TcpConnection Send()
        {
            return new TcpConnection(State.Send(this));
        }

        public TcpConnection Acknowledge()
        {
            return new TcpConnection(State.Acknowledge(this));
        }

        public TcpConnection Synchronize()
        {
            return new TcpConnection(State.Synchronize(this));
        }

        public virtual TcpConnection ProcessOctet(TcpOctetStream stream)
        {
            return this;
        }
    }
}
