using System.Collections.Generic;

namespace Ploeh.Samples.TCP
{
    public class TcpEstablished : TcpState
    {
        public static TcpState Instance = new TcpEstablished();

        private TcpEstablished()
        {
        }

        public override void Close(TcpConnection connection)
        {
            // send FIN, receive ACK of FIN

            connection.State = TcpListen.Instance;
        }

        public override void Transmit(
            TcpConnection connection,
            TcpOctetStream stream)
        {
            connection.ProcessOctet(stream);
        }
    }
}