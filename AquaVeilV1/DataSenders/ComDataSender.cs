using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using AquaVeilV1.Draw;
using AquaVeilV1.Settings;
using AquaVeilV1.Utils;

namespace AquaVeilV1.DataSenders
{
    class ComDataSender : IDataSender
    {
        private static String _comPortName = "COM2";

        private SerialPort _comPort;

        public ComDataSender()
        {
            _comPort = new SerialPort(_comPortName);
        }

        public string Connect()
        {
            string result = "";

            for (int i = 3; i < 7; i++)
            {
                try
                {
                    _comPort.Open();
                    break;
                }
                catch (IOException ex)
                {
                    _comPort = new SerialPort($"COM{i}");
                }
                catch (UnauthorizedAccessException ex)
                {
                    result = "Соединение уже установленно!";

                    Logger.error($"Соединение уже установленно с устройством на порте: {_comPortName}", ex);

                    return result;
                }
            }

            _comPortName = ComPort.PortName;
            if (_comPort.IsOpen)
            {
                ComPort.BaudRate = 115200;
                ComPort.Encoding = Encoding.ASCII;
                ComPort.WriteTimeout = 500;
                ComPort.ReadTimeout = 500;

                Logger.info($"Установленно соединение с устройством на порте: {_comPortName}");
            }
            else
            {
                Logger.error("Не удалось соедениться с устройством, проверьте драйвера и соединение");
            }


            result = ComPort.IsOpen ? "Установленно соединение с устройством" : "Не удалось соединиться с устройством, проверьте драйвера и соединение";

            return result;
        }

        public void SendData(string response)
        {
            if (!ComPort.IsOpen)
            {
                Connect();
            }

            try
            {
                byte[] data = Encoding.ASCII.GetBytes(response);
                ComPort.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Logger.error("Порт занят или устройство не подключено!", ex);
            }

            ComPort.Close();
        }

        public void sendStart()
        {
            SendData(SwingCommands.Start);
        }

        public void sendStop()
        {
            SendData(SwingCommands.Stop);
        }

        public void SendSettings()
        {
            SendData(SwingCommands.TimeRg());
        }

        public void SendFrame(clMap map)
        {
            byte[][] frameMap = map.getMapFromCom();

            for (int i = 0; i < map.Height; i++)
            {
                SendData(SwingCommands.writeLine(frameMap[i]));

                Thread.Sleep(400);
            }
        }

        public SerialPort ComPort
        {
            get => _comPort;
            set => _comPort = value;
        }

        public string ComPortName
        {
            get => _comPortName;
            set => _comPortName = value;
        }
    }
}