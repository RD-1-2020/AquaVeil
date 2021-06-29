using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AquaVeilV1
{
    class DataSender
    {
        private static string _targetIp = Settings.Net.Instance.SwingIp;
        private static string _targetPort = Settings.Net.Instance.Port;


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

        public string ConnectToServer()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(_targetIp, int.Parse(_targetPort));

                client.Close();
                return "Успешно!";
            }
            catch (SocketException e)
            {
                return $"Exception: {e.Message}";
            }
            catch (Exception e)
            {
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

                    NetworkStream stream = client.GetStream();
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(response);
                    stream.Write(data, 0, data.Length);

                    // Закрываем потоки
                    stream.Close();
                    client.Close();

                    Debug.WriteLine("Успешно!");
                }
                catch (SocketException e)
                {
                    Debug.WriteLine($"Exception: {e.Message}");
                }
                catch (Exception e)
                {
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
                case 5:
                {
                    responseString = constructResponceString(commandNumber, Settings.Swing.Instance.PixSpacing);
                    break;
                }
                case 6:
                {
                    responseString = constructResponceString(commandNumber, Settings.Swing.Instance.PixPeriod);
                    break;
                }
                case 7:
                {
                    responseString = constructResponceString(commandNumber, Settings.Swing.Instance.PixMinAmplitude);
                    break;
                }
            }
            SendData(responseString+"\0");
        }
    }
}

