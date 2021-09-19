using System;
using System.IO;
using System.Xml.Serialization;
using AquaVeilV1.Utils;

namespace AquaVeilV1.Settings
{
    [Serializable]
    public class InjectorMap
    {

        // TODO: ЗАЩИТА ОТ ПРИДУРКА
        public Map[] _map { get; set; }

        public String _defaultFileName { get; set; } // Стандартный файл с маппингом
        

        public void getFromFile(String fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(InjectorMap));

                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    InjectorMap tmp = (InjectorMap)serializer.Deserialize(stream);
                    // При вытскивание класса из файла нам нужна только мапа
                    _map = tmp._map;
                }
            }
            catch (Exception e) // Если что-то пошло не так - выводим ошибку
            {
                Logger.error($"Ошибка при получении маппинга из файла \"{fileName}\"", e);
            }
        }

        public void saveToFile(String fileName)
        {
            try
            {
                if (!fileName.Contains(".xml"))
                {
                    fileName += ".xml"; // Если файл не содержит расширения .xml добавляем его
                }

                XmlSerializer serializer = new XmlSerializer(typeof(InjectorMap));

                using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream,this); // Сохраняем данный класса в файл

                    Logger.info($"Маппинг сохранён в файл: {fileName}");
                }
            }
            catch (Exception e)
            {
                Logger.error($"Ошибка при сохранении файла \"{fileName}\"", e);
            }
        }

        public void initMapping()
        {
            _defaultFileName = "injectorMapping.xml";

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(InjectorMap));

                using (FileStream stream = new FileStream(_defaultFileName, FileMode.Open))
                {
                    InjectorMap tmp = (InjectorMap)serializer.Deserialize(stream);

                    _map = tmp._map; // Если файл есть то сейвим оттуда
                }
            }
            catch (FileNotFoundException e)
            {
                _map = new Map[Frame.Instance.Width];

                for (uint i = 0; i < Frame.Instance.Width; i++)
                {
                    _map[i] = new Map(i + 1, i + 1); //  иначе сейвим в новый файл 
                }

                saveToFile(_defaultFileName);
            }
            catch (Exception e)
            {
                Logger.error($"Ошибка при инициализации маппинга файла", e);
            }
        }

        public void updateMapping()
        {
            saveToFile(_defaultFileName);
        }
    }
}