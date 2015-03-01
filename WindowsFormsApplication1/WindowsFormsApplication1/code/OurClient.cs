using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.code
{
    class OurClient
    {
        IPEndPoint ipEndPoint;
        Socket sender;
        public string data;
        public delegate void MessageReceivedDelegate(string msg);
        public event MessageReceivedDelegate MessageReceived;

        public OurClient(IPEndPoint _ipEndPoint)
        {
            ipEndPoint = _ipEndPoint;
            sender = new Socket(_ipEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.IP);
        }

        public void SendMessage(string mes)
        {
            
            sender.Connect(ipEndPoint);
            byte[] msg = Encoding.UTF8.GetBytes(mes);
            int bytesSent = sender.Send(msg);
            
        }

        public void Close()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}
