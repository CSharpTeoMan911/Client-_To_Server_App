using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client__To_Server_App
{
    internal class Server_Connection<Id, Password, Subject, Week, BinaryPictureData, FileName>
    {   
        public Task<bool> Register(Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "10" + "0" + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[100];

                        stream.Read(buffer, 0, buffer.Length);

                        switch ((Encoding.ASCII.GetString(buffer)).Contains("[OK]"))
                        {
                            case true:
                                return Task.FromResult(true);

                            case false:
                                return Task.FromResult(false);
                        }
                    }
                }

                return Task.FromResult(false);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }


        public Task<bool> Log_Out(Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "09" + "0" + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[100];

                        stream.Read(buffer, 0, buffer.Length);

                        switch ((Encoding.ASCII.GetString(buffer)).Contains("[OK]"))
                        {
                            case true:
                                return Task.FromResult(true);

                            case false:
                                return Task.FromResult(false);
                        }
                    }
                }

                return Task.FromResult(false);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
       
        public Task<bool> Log_In(Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "08" + "0" + "00" + "[" + id as string + "]" + "[" +password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[100];

                        stream.Read(buffer, 0, buffer.Length);

                        switch((Encoding.ASCII.GetString(buffer)).Contains("[OK]"))
                        {
                            case true:
                                return Task.FromResult(true);

                            case false:
                                return Task.FromResult(false);
                        }
                    }
                }

                return Task.FromResult(false);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        public Task<bool> Register()
        {
            return null;
        }


        public Task<byte[]> Download_Profile_Picture(Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "00" + "0" + "00" + "[" + id as string + "]" + "[" + password as string + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[10000000];

                        stream.Read(buffer, 0, buffer.Length);
                        

                        return Task.FromResult(buffer);
                    }
                }
            }
            catch
            { 
                return Task.FromResult(new byte[1] { 0 });
            }
        }

        public Task<string> Download_Grades(Id id, Password password, Subject subject)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "01" + subject as string + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[100];

                        stream.Read(buffer, 0, buffer.Length);

                        return Task.FromResult(Encoding.ASCII.GetString(buffer));
                    }
                }
            }
            catch 
            {
                return Task.FromResult(String.Empty);
            }
        }



        
        public Task<string> Download_Contacts(Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "03" + "0" + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[70];

                        stream.Read(buffer, 0, buffer.Length);

                        return Task.FromResult(Encoding.ASCII.GetString(buffer));
                    }
                }
            }
            catch
            {
                return Task.FromResult(String.Empty);
            }
        }
       

        public Task<Tuple<byte[], byte[]>> Download_Institutions_Contact_Pictures(Id id, Password password)
        {
            byte[] buffer1 = new byte[10000000];
            byte[] buffer2 = new byte[10000000];

            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "04" + "0" + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        stream.Read(buffer1, 0, buffer1.Length);
                    }
                }

                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "05" + "0" + "00" + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        stream.Read(buffer2, 0, buffer2.Length);
                    }
                }

                return Task.FromResult(new Tuple<byte[], byte[]>(buffer1, buffer2));
            }
            catch
            {
                return Task.FromResult(new Tuple<byte[], byte[]>(new byte[1] { 1 }, new byte[1] { 1 }));
            }
        }

        public Task<string> Download_Subject_Materials(Subject subject, Week week, Id id, Password password)
        {
            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "06" + subject as string +  week as string + "[" + id as string + "]" + "[" + password + ']';

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[70];

                        stream.Read(buffer, 0, buffer.Length);

                        return Task.FromResult(Encoding.ASCII.GetString(buffer));
                    }
                }
            }
            catch
            {
                return Task.FromResult(String.Empty);
            }
        }


        public Task<byte[]> Download_Material_File(Subject subject, Week week, FileName filename, Id id, Password password)
        {
            byte[] File_Buffer = new byte[1];

            try
            {
                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {
                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "07" + subject as string + week as string + "[" + id as string + "]" + "[" + password + ']' + filename;

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);

                        byte[] buffer = new byte[100];

                        stream.Read(buffer, 0, buffer.Length);
                        

                        File_Buffer = new byte[Convert.ToInt32(Encoding.ASCII.GetString(buffer))];
                    }
                }

                using (var client = new TcpClient(App.Ip, Convert.ToInt32(App.Port)))
                {

                    client.ReceiveBufferSize = 18000;
                    client.SendBufferSize = 18000;

                    string messageToSend = "02" + subject as string + week as string + "[" + id as string + "]" + "[" + password + ']' + filename;

                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(sendData, 0, sendData.Length);
                        stream.Read(File_Buffer, 0, File_Buffer.Length);

                        return Task.FromResult(File_Buffer);
                    }
                }
            }
            catch { return Task.FromResult(new byte[1] { 1 }); }
        }

        /*
        public Task<bool> Upload_Profile_Picture(byte[] pictureData)
        {
            try
            {
                using (var client = new TcpClient("192.168.56.1", 20))
                {
                    using (var stream = client.GetStream())
                    {
                        CompressBytesToStream(stream, pictureData);                      
                    }
                }
            }
            catch
            {

            }

            return Task.FromResult(false);
        }

        private static void CompressBytesToStream(NetworkStream stream, byte[] pictureData)
        {
            try
            {
                var compressor = new GZipStream(stream, CompressionLevel.Optimal, leaveOpen: true);
                compressor.Write(pictureData, 0, pictureData.Length);
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        */
    }
}
