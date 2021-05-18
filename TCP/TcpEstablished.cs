using System.Collections.Generic;

namespace Ploeh.Samples.TCP
{
    public class TcpEstablished : TcpState
    {
        public static TcpState Instance = new TcpEstablished();

        private TcpEstablished()
        {
        }
    }
}