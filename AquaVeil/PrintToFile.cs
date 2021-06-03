using AquaVeil.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaVeil
{
    class PrintToFile
    {

        private List<FileToSave> Files;

        private Settings settings;


        /// <summary>
        /// Файлы готовые к печати
        /// </summary>
        public List<FileToSave> files { get => Files; set => Files = value; }

        public PrintToFile(List<clMap> frameList)
        {
            Files = new List<FileToSave>();

            settings = new Settings(frameList[0].Width, frameList[0].Height, frameList.Count);

            int fileNum = 1;
            foreach (clMap cl in frameList) {
                Files.Add(new FileToSave(cl.MapCanvas,fileNum, settings));
                fileNum++;
            }
        }

        public void PrintAll() {
            Thread printTh;
            foreach (FileToSave file in Files) {
                printTh = new Thread(new ThreadStart(file.WriteToFile));
                printTh.Start();
            }
            MessageBox.Show("Было успешно создано " + Files.Count + " файлов","Успешно!");
        }
    }
}
