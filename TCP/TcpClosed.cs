namespace Ploeh.Samples.TCP
{
    public class TcpClosed : TcpState
    {
        public static TcpState Instance = new TcpClosed();

        private TcpClosed()
        {
        }

        public override void ActiveOpen(TcpConnection connection)
        {
            // Send SYN, receive SYN, Ack, etc.

            connection.State = TcpEstablished.Instance;
        }

        public override void PassiveOpen(TcpConnection connection)
        {
            connection.State = TcpListen.Instance;
        }
    }
}