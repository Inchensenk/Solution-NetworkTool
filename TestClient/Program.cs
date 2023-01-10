using Network;

namespace TestClient
{
    public class Program
    {
        public static async void Main(string[] args)
        {
            var provider = new NetworkProvider();
            var responce = await provider.GetAsync(new Solution_NetworkTool.Messages.RequestMessage() { Method = "Greeting" });
            Console.WriteLine(responce.ToString());
            Console.Read();
        }
    }
}