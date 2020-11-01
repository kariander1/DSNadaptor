using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;
using System.Text.RegularExpressions;
namespace DSNadaptor
{
    class SFTP
    {
        public string username { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string MyProperty { get; set; }
        public SftpClient client { get; set; }
        public SFTP(string add, string user, string keyFilePath)
        {
            PrivateKeyFile keyFile = new PrivateKeyFile(keyFilePath);
            PrivateKeyFile[] keyFiles = new PrivateKeyFile[] { keyFile };
            this.client = new SftpClient(add, user, keyFiles);

        }
        public string[] ListDir(string uri, string format)
        {

            this.client.Connect();

            List<string> files = this.client.ListDirectory(uri).Select(s => s.FullName).ToList();
            string[] filtered = files.Where(item => Path.GetFileName(item).StartsWith(format)).ToArray();
            //this.client.lis
            this.client.Disconnect();
            return filtered;



        }
        public DateTime GetFileDate(string uri)
        {
            this.client.Connect();

            DateTime date = this.client.GetLastWriteTimeUtc(uri);
            //this.client.lis
            this.client.Disconnect();
            return date;

        }
        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
        public byte[] DownloadFile(string uri)
        {
            this.client.Connect();
            byte[] m_Bytes;
            using (Stream fileStream = File.Create(@".\SFTP_TEMP"))
            {
                this.client.DownloadFile(uri, fileStream);
                m_Bytes = ReadToEnd(fileStream);
            }


           this.client.Disconnect();
            return m_Bytes;

        }
    }
    //    SessionOptions sessionOptions = new SessionOptions
    //{
    //    Protocol = Protocol.Sftp,
    //    HostName = "192.168.1.111",
    //    UserName = "jpl",
    //    SshHostKeyFingerprint = "ssh-ed25519 256 QVOytJywAurmhAdzKS+8fi1tVnOdZQRlevPpNFkEPo4=",
    //    SshPrivateKeyPath = @"C:\Users\SpaceIL\Desktop\test.ppk",
    //};


}
