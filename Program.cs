using AdvancedSharpAdbClient;

namespace AdvancedSharpAdbClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var client = new AdbClient();
            client.Connect("127.0.0.1:62001");
            var device = client.GetDevices().FirstOrDefault(); // Get first connected device
        }
    }
}