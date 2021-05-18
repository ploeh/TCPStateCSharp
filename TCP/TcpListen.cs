using System.Collections.Generic;

namespace Ploeh.Samples.TCP
{
    public class TcpListen : TcpState
    {
        public static TcpState Instance = new TcpListen();

        private TcpListen()
        {
        }

        public override void Send(TcpConnection connection)
        {
            // Send SYN, receive SYN, ACK, etc.

            connection.State = TcpEstablished.Instance;
        }
    }
}