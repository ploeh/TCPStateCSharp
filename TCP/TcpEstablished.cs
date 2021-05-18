using System.Collections.Generic;

namespace Ploeh.Samples.TCP
{
    public class TcpEstablished : TcpState
    {
        public static TcpState Instance = new TcpEstablished();

        private TcpEstablished()
        {
        }

        public override TcpState Close(TcpConnection connection)
        {
            // send FIN, receive ACK of FIN

            connection.State = TcpListen.Instance;
            return connection.State;
        }

        public override TcpState Transmit(
            TcpConnection connection,
            TcpOctetStream stream)
        {
            TcpConnection newConnection = connection.ProcessOctet(stream);
            return newConnection.State;
        }
    }
}