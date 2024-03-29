﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TestTcpServer
{
    class Program
    {
        public static void Server()
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            TcpListener server = new TcpListener(localAddr, port);
            // Запуск в работу
            server.Start();
            // Бесконечный цикл
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    try
                    {
                        if (stream.CanRead)
                        {
                            byte[] myReadBuffer = new byte[1024];
                            StringBuilder myCompleteMessage = new StringBuilder();
                            int numberOfBytesRead = 0;
                            do
                            {
                                numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);
                                myCompleteMessage.AppendFormat("{0}", Encoding.UTF8.GetString(myReadBuffer, 0, numberOfBytesRead));
                            }
                            while (stream.DataAvailable);
                            Console.WriteLine(Encoding.UTF8.GetString(myReadBuffer));
                        }
                    }
                    finally
                    {
                        stream.Close();
                        client.Close();
                    }
                }
                catch
                {
                    server.Stop();
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            new Thread(new ThreadStart(Server)).Start();
        }
    }
}
