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

        public void ActiveOpen()
        {
            State.ActiveOpen(this);
        }

        public void PassiveOpen()
        {
            State.PassiveOpen(this);
        }

        public void Close()
        {
            State.Close(this);
        }

        public void Send()
        {
            State.Send(this);
        }

        public void Acknowledge()
        {
            State.Acknowledge(this);
        }

        public void Synchronize()
        {
            State.Synchronize(this);
        }

        public virtual void ProcessOctet(TcpOctetStream stream)
        {
        }
    }
}
