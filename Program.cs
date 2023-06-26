using System.Diagnostics;

namespace AdvancedSharpAdbClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "/bin/bash", Arguments = "adb", };
            Process proc = new Process() { StartInfo = startInfo, };
            proc.Start();
        }
    }
}