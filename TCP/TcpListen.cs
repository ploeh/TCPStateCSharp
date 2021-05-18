using System.Collections.Generic;

namespace Ploeh.Samples.TCP
{
    public class TcpListen : TcpState
    {
        public static TcpState Instance = new TcpListen();

        private TcpListen()
        {
        }
    }
}