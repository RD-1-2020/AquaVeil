using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using AquaVeilV1.Settings;
using AquaVeilV1.Utils;

namespace AquaVeilV1.DataSenders
{
    class TcpDataSender : IDataSender
    {
        private static string _targetIp = Net.Instance.SwingIp;
        private static string _targetPort = Net.Instance.Port;


        public string TargetIp
        {
            get => _targetIp;
            set => _targetIp = value;
        }

        public string TargetPort
        {
            get => _targetPort;
            set => _targetPort = value;
        }

        public string Connect()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(_targetIp, int.Parse(_targetPort));

                client.Close();

                Logger.info($"Подключение к {TargetIp}:{TargetPort} успешно установленно");

                return "Успешно!";
            }
            catch (SocketException e)
            {
                Logger.error(e);
                return $"Exception: {e.Message}";
            }
            catch (Exception e)
            {
                Logger.error(e);
                return $"Exception: {e.Message}";
            }
        }

        public void SendData(string response)
        {
            new Thread(delegate()
            {
                try
                {
                    TcpClient client = new TcpClient();
                    client.Connect(_targetIp, int.Parse(_targetPort));

                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] data = System.Text.Encoding.UTF8.GetBytes(response);
                        stream.Write(data, 0, data.Length);
                    }

                    Debug.WriteLine("Успешно!");
                }
                catch (SocketException e)
                {
                    Logger.error(e);
                    Debug.WriteLine($"Exception: {e.Message}");
                }
                catch (Exception e)
                {
                    Logger.error(e);
                    Debug.WriteLine($"Exception: {e.Message}");
                }
            }).Start();
        }

        private string constructResponceString(Int32 fisrtByte, Int32 secondByte)
        {
            string responseString = "";

            responseString += fisrtByte > 15 ? Convert.ToString(fisrtByte, 16) : "0" + Convert.ToString(fisrtByte, 16);

            responseString += secondByte > 15 ? Convert.ToString(secondByte, 16) : "0" + Convert.ToString(secondByte, 16);

            return responseString;
        }

        public void SendCommand(int commandNumber)
        {
            string responseString = "";
            switch (commandNumber)
            {
                case 0:
                {
                    responseString = constructResponceString(commandNumber, DateTime.Now.Hour);
                    break;
                }
                case 1:
                {
                    responseString = constructResponceString(commandNumber, DateTime.Now.Minute);
                        break;
                }
                case 2:
                {
                    responseString = constructResponceString(commandNumber, (int)DateTime.Now.DayOfWeek);
                        break;
                }
                case 3:
                {
                    responseString = constructResponceString(commandNumber, DateTime.Now.Day);
                        break;
                }
                case 4:
                {
                    responseString = constructResponceString(commandNumber, DateTime.Now.Month);
                    break;
                }
            }
            SendData(responseString+"\0");
        }
    }
}

