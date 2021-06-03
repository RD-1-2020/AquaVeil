using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeil.GeneralClasses
{

    //Класс для отрисовки кадров
    public class Drawer_Frames
    {

        private Dictionary<int, clMap> Dictionary_Frames = new Dictionary<int, clMap>();

        //Массив кадров для доступа по нажатию
        private clMap[] _frames_array;

        public clMap[] frames_array
        {
            get
            {
                return _frames_array;
            }
        }

        private int frame_width;

        public int frame_wh
        {
            get
            {
                return frame_width;
            }
        }

        double _scale;
        /// <summary>
        /// Конструктор отрисовщика
        /// </summary>
        /// <param name="frames">Кадры</param>
        /// <param name="scale">Масштаб кадров</param>
        public Drawer_Frames(Frames frames, double scale)
        {
            int i = 0;
            foreach (var element in frames.Map)
            {
                Dictionary_Frames.Add(i, element);
                i++;
            }
            _scale = scale;
            frame_width = (int)(frames.Map[0].Width * frames.Map[0].PixelWidth * _scale + 10);
        }

        // Проверка существует ли данный кадр (для отрисовки)
        public bool is_frame(int x)
        {
            try
            {
                clMap sergey = _frames_array[x];
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Отрисовка кадров
        /// </summary>
        /// <param name="g">Поле</param>
        /// <param name="width">Длинна поля</param>
        public void Drawing(Graphics g)
        {
            g.Clear(Color.Gray);
            _frames_array = new clMap[Dictionary_Frames.Count];
            int xx = 10;
            int i = 0;
            foreach (var frame in Dictionary_Frames.Values)
            {
                g.DrawImage(frame.pic, new Point(xx, 10));
                _frames_array[i] = frame;
                i++;
                xx += (frame.pic.Width + 10);
            }
        }

    }
}
