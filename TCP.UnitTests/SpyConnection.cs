using System.Collections;
using System.Collections.Generic;

namespace Ploeh.Samples.TCP.UnitTests
{
    internal class SpyConnection : TcpConnection, IReadOnlyCollection<TcpOctetStream>
    {
        private readonly List<TcpOctetStream> observations;

        public SpyConnection()
        {
            observations = new List<TcpOctetStream>();
        }

        public int Count => observations.Count;

        public IEnumerator<TcpOctetStream> GetEnumerator()
        {
            return observations.GetEnumerator();
        }

        public override void ProcessOctet(TcpOctetStream stream)
        {
            observations.Add(stream);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}