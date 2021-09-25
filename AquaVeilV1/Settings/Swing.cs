using System;
using System.IO;
using System.Xml.Serialization;
using AquaVeilV1.Utils;

namespace AquaVeilV1.Settings
{
    /// <summary>
    /// Singleton Pattern
    /// Настройки качелей
    /// </summary>
    [Serializable]
    public class Swing
    {
        private static readonly Lazy<Swing> instanceHolder =
            new Lazy<Swing>(() => new Swing());

        public static Swing Instance
        {
            get { return instanceHolder.Value; }
        }

        public String fileName = "SwingSettings.xml";

        public byte tic_data;
        public byte tic_clk;
        public byte tic_latch;
        public byte tic_clear;
        public UInt16 tic_pause;

        public void getFromFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Swing));

                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    Swing tmp = (Swing) serializer.Deserialize(stream);

                    tic_data = tmp.tic_data;
                    tic_clk = tmp.tic_clk;
                    tic_latch = tmp.tic_latch;
                    tic_clear = tmp.tic_clear;
                    tic_pause = tmp.tic_pause;
                }
            }
            catch (FileNotFoundException)
            {
                saveToFile();
                getFromFile();
            }
            catch (Exception e)
            {
                Logger.error($"Ошибка при получении настроек качелей из файла \"{fileName}\"", e);
            }
        }

        public void saveToFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Swing));

                using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, this);

                    Logger.info($"Настройки качелей сохранены в файл: {fileName}");
                }
            }
            catch (Exception e)
            {
                Logger.error($"Ошибка при сохранении файла \"{fileName}\"", e);
            }
        }
    }
}