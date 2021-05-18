namespace Ploeh.Samples.TCP
{
    public class TcpClosed : TcpState
    {
        public static TcpState Instance = new TcpClosed();

        private TcpClosed()
        {
        }
    }
}