using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.code
{
    class Server
    {
        EndPoint ipEndPoint;
        Socket sListener;
        public string data;
        public delegate void MessageReceivedDelegate(string msg);
        public event MessageReceivedDelegate MessageReceived;
        byte[] bytes = new byte[1024];

        public Server(IPEndPoint _ipEndPoint)
        {
            ipEndPoint = _ipEndPoint;
            sListener = new Socket(_ipEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
        }
        public void Listen()
        {
            sListener.Bind(ipEndPoint);
           
            //sListener.BeginAccept(new AsyncCallback(MyAcceptCallBack), sListener);
            //
            //sListener.BeginReceiveFrom( new AsyncCallback(MyAcceptCallBack), sListener);
            sListener.BeginReceiveFrom(bytes, 0, 1024, SocketFlags.None, ref ipEndPoint, new AsyncCallback(MyAcceptCallBack), sListener);
        }
        public void MyAcceptCallBack(IAsyncResult ia)
        {
            Socket socket = (Socket)ia.AsyncState;
            //Socket ns = socket.EndAccept(ia);
            int ns = socket.EndReceiveFrom(ia, ref ipEndPoint);
            data = null;
            //byte[] bytes = new byte[1024];
            //int bytesRec = socket.Receive(bytes);
            data += Encoding.UTF8.GetString(bytes, 0, ns);
            if (MessageReceived != null)
                MessageReceived(data);
            //socket.BeginAccept(new AsyncCallback(MyAcceptCallBack), socket);
            sListener.BeginReceiveFrom(bytes, 0, 1024, SocketFlags.None, ref ipEndPoint, new AsyncCallback(MyAcceptCallBack), sListener);
        }
        public void Close()
        {
            sListener.Shutdown(SocketShutdown.Both);
            sListener.Close();
        }
    }
}
