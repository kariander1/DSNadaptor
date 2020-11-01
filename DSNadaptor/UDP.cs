using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;



namespace DSNadaptor
{
    class UDP
    {
        public int counts { get; set; }
        public string lastErrorMessage { get; set; }
        public socketbundle bundle { get; set; }

        public UDP(string server, int port)
        {
            this.bundle = OpenUDP(server, port);
            lastErrorMessage = "";
        }
        public socketbundle OpenUDP(string server, int port)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress serverAddr;
            IPEndPoint endPoint;

            //if(server.ToLower() == "localhost")
            //{
            //    server = Dns.GetHostName();
            //}

            try
            {
                serverAddr = IPAddress.Parse(server);
            }
            catch (FormatException e)
            {
                lastErrorMessage = e.Message;
                return null;
            }
            try
            {
                endPoint = new IPEndPoint(serverAddr, port);
            }
            catch (ArgumentOutOfRangeException e)
            {
                lastErrorMessage = e.Message;
                return null;
            }
           
            socketbundle item = new socketbundle(sock, serverAddr, endPoint);

            return item;
        }
        public bool SendUDPdata(string data)
        {
            byte[] send_buffer = Encoding.ASCII.GetBytes(data);

            try
            {
                this.bundle.getsock.SendTo(send_buffer, this.bundle.getendPoint);
                return true;
            }
            catch (Exception e)
            {
                lastErrorMessage = e.Message;
                Console.WriteLine(e.Message);
            }
            return false;
           
        }
        public bool SendUDPdata(byte[] data)
        {
            // byte[] send_buffer = Encoding.ASCII.GetBytes(data);
            //this.bundle.getsock.SendTo(data, this.bundle.getendPoint);

            try
            {
                this.bundle.getsock.SendTo(data, this.bundle.getendPoint);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
    class socketbundle
    {
        Socket sock;
        
        IPEndPoint endPoint;

        public socketbundle(Socket sock, IPAddress serverAddr, IPEndPoint endPoint)
        {
            this.sock = sock;
       
            this.endPoint = endPoint;

        }
        public Socket getsock
        {
            get
            {
                return this.sock;
            }
        }
        public IPEndPoint getendPoint
        {
            get
            {
                return this.endPoint;
            }
        }

    }
}
