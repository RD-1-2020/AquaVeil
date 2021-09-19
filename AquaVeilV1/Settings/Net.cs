using System;
using System.ComponentModel;

namespace AquaVeilV1.Settings
{
    public class Net
    {
        private static string _swingIp = "127.0.0.1";
        private static string _port = "8888";

        [Category("Качели")]
        [DisplayName("IP-Адрес")]
        public string SwingIp
        {
            get => _swingIp;
            set => _swingIp = value;
        }

        [Category("Качели")]
        [DisplayName("Порт")]
        public string Port
        {
            get => _port;
            set => _port = value;
        }

        private static readonly Lazy<Net> instanceHolder =
            new Lazy<Net>(() => new Net());

        public Net()
        {
        }

        public static Net Instance
        {
            get { return instanceHolder.Value; }
        }

    }
}