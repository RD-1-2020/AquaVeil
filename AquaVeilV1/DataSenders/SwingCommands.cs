using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AquaVeilV1.Settings;

namespace AquaVeilV1.DataSenders
{
    static class SwingCommands
    {
        private static String START = "~" + (char) 8 + "start" + (char) 10;

        private static String STOP = "~" + (char)7 + "stop" + (char)10;

        public static string Start => START;

        public static string Stop => STOP;

        public static string TimeRg()
        {
            byte fPauseByte = Convert.ToByte(Swing.Instance.tic_pause >> 8 & 0x00ff);
            byte scPauseByte = Convert.ToByte(Swing.Instance.tic_pause & 0x00ff);

            return "~" + (char) 17 + "time_rg|"+ 
                   (char) Swing.Instance.tic_data +
                   (char) Swing.Instance.tic_clk +
                   (char) Swing.Instance.tic_latch +
                   (char) Swing.Instance.tic_clear +
                   (char) fPauseByte +
                   (char) scPauseByte
                   + (char) 10;
        }

        public static string writeLine(Byte[] line)
        {
            String command =  "~" + (char) 21 + "wr|";

            String lines = ASCIIEncoding.ASCII.GetString(line);
            return command + lines + (char)10;
        }
    }
}
