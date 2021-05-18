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

            connection.State = TcpEstablished.Instance;
            return connection.State;
        }

        public override TcpState PassiveOpen(TcpConnection connection)
        {
            connection.State = TcpListen.Instance;
            return connection.State;
        }
    }
}