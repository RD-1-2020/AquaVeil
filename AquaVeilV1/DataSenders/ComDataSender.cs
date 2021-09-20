using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
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
                Logger.info($"Установленно соединение с устройством на порте: {_comPortName}");

                ComPort.Encoding = Encoding.ASCII;
                ComPort.WriteTimeout = 500;
                ComPort.ReadTimeout = 500;

                String response = "start";

                byte[] data = System.Text.Encoding.ASCII.GetBytes(response);
                ComPort.Write(data, 0, data.Length);
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
            throw new NotImplementedException();
        }

        public String SendTestData()
        {
            String request;
            String response;

            if (!ComPort.IsOpen)
            {
                request = "Для отправки для начала установите соединение с устройством";

                Logger.error("Попытка отправить данные без соединения с устройством");

                return request;
            }

            response = "~19WR|FFFFFFFFFFFFFFFFFFFFFFFFFFFF0A";

            byte[] data = System.Text.Encoding.ASCII.GetBytes(response);
            ComPort.Write(data, 0, data.Length);


            request = "Тестовая строка была отправленна";

            return request;
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