using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaVeil.GeneralClasses
{
    /// <summary>
    /// Файл для сохранения
    /// </summary>
    public class FileToSave
    {
        /// <summary>
        /// Текст файла
        /// </summary>
        private string text;

        /// <summary>
        /// Фйаловый поток с файлом
        /// </summary>
        private StreamWriter FileFrame;

        /// <summary>
        /// Путь до файла
        /// </summary>
        private string FileName;

        public FileToSave(int[][] frameArray, int fileNum, Settings settings)
        {
            text += $"0x{Convert.ToString(settings.Count, 16)}" + "\n"; 
            text += $"0x{Convert.ToString(settings.Width, 16)}" + "\n";
            text += $"0x{Convert.ToString(settings.Height, 16)}" + "\n";

            for (int i = 0; i < frameArray[i].Length; i++) {
                for (int j = 0; j < frameArray.Length; j++) {
                    text += frameArray[j][i];
                }
                text += "\n";
            }
            
            FileName = Directory.GetCurrentDirectory() + @"\Frames\" + fileNum + ".txt";
         }

        /// <summary>
        /// Функция создаёт файл с кадром в папке "Frames"
        /// </summary>
        public void WriteToFile() {
            try
            {
                using (FileFrame = new StreamWriter(FileName, false, System.Text.Encoding.Default))
                {
                    FileFrame.WriteAsync(text);
                }
            }
            catch (Exception)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Frames\");
                using (FileFrame = new StreamWriter(FileName, false, System.Text.Encoding.Default))
                {
                    FileFrame.WriteAsync(text);
                }
            }
        }
    }
}
