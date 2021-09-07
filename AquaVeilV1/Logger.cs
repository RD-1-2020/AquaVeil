using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaVeilV1
{
    static class Logger
    {
        public static void log(String logText)
        {
            MessageBox.Show(logText);
        }
    }
}
