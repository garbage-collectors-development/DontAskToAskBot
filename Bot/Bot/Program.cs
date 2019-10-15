using System;
using System.Threading.Tasks;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(null);
            client.RunAsync().GetAwaiter().GetResult();
        }
    }
}
