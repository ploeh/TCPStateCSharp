namespace Ploeh.Samples.TCP
{
    public class TcpClosed : TcpState
    {
        public static TcpState Instance = new TcpClosed();

        private TcpClosed()
        {
        }

        public override TcpState ActiveOpen(TcpConnection connection)
        {
            // Send SYN, receive SYN, Ack, etc.

            return TcpEstablished.Instance;
        }

        public override TcpState PassiveOpen(TcpConnection connection)
        {
            return TcpListen.Instance;
        }
    }
}