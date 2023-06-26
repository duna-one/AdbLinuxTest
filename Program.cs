using AdvancedSharpAdbClient;

namespace AdvancedSharpAdbClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(AdbServer.Instance.GetStatus().IsRunning);
        }
    }
}