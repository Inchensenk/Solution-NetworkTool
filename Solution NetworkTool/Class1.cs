using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Common
{
    public class Connection
    {
        private readonly TcpClient _client;
        private readonly NetworkStream _stream;

        public Connection(string host, int port)
        {
            _client = new TcpClient(host, port);
            _stream = _client.GetStream();

        }

        public Connection(string host, int port)
        {
            _client = new TcpClient(host, port);
            _stream = _client.GetStream();
        }

        public async Task<byte[]?> RequestAsync(byte[] data)
        {
            await _stream.WriteAsync(data);
            return await ReceiveAsync();
        }

        private async Task<byte[]?> ReceiveAsync()
        {
            byte[] data = new byte[256];

            int bytes;

            do
            {
                bytes = await _stream.ReadAsync(data, 0);
            }
        }
    }
}