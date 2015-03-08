using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PortScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentPort = 20;
            for (int i = CurrentPort; i <= 80; i++)
            {
                ThreadPool.QueueUserWorkItem(Check, (object)CurrentPort);
                CurrentPort++;
            }
            Console.WriteLine(1);
            Console.ReadLine();

        }
        public static void Check(object state)
        {
            TcpClient client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", (int) state);
                Console.WriteLine(state + " is open");

            }
            catch
            {
                Console.WriteLine(state + " is closed");
            }
            
        }
    }
}
