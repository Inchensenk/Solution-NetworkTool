using Common;
using Solution_NetworkTool;
using Solution_NetworkTool.Messages;

namespace Network
{
    /*провайдер который будет посылать реквесты и получать респонсы*/
    public class NetworkProvider
    {
        private readonly string _host;
        private readonly string _port;



        /// <summary>
        /// получаем некий реквест
        /// </summary>
        /// <param name="requestMessage">получаем некий респонс</param>
        /// <returns></returns>
        public async Task<ResponseMessage> GetAsync(RequestMessage requestMessage)
        {
            var connection = new Connection();
        }

        public NetworkProvider(string host, string? port)
        {
            _host = host;
            _port= port;
        }

        public NetworkProvider()
        {
        }

        public async Task<ResponseMessage> GetAsync(RequestMessage requestData)
        {
            var connection = new Connection(_host, _port);

            var data = SerHelp.Deserialize<>
        }
    }
}