using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace AquaVeilV1.Utils
{
    static class Logger
    {
        private static ConcurrentQueue<String> logQueue = new ConcurrentQueue<string>();

        public static void info(String info)
        {
            Debug.WriteLine($"[INFO {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {info}.");

            printToFile($"[INFO {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {info}.");
        }

        public static void error(String exceptionText)
        {
            Debug.WriteLine($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {exceptionText}.");

            printToFile($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {exceptionText}.");
        }

        public static void error(String exceptionText, Exception ex)
        {
            Debug.WriteLine($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {exceptionText}\n[Exception]: {ex.Message}\n{ex.StackTrace}.");

            printToFile($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {exceptionText}\n[Exception]: {ex.Message}\n{ex.StackTrace}.");
        }

        public static void error(Exception ex)
        {
            Debug.WriteLine($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {ex.Message}\n{ex.StackTrace}.");

            printToFile($"[ERROR {DateTime.Now.Hour}:{DateTime.Now.Minute}]: {ex.Message}\n{ex.StackTrace}.");
        }

        private static void printToFile(String logMsg)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    sw.WriteLineAsync(logMsg);
                }
            }
            catch
            {
                new Thread(delegate() {
                    Thread.Sleep(100);
                    printToFile(logMsg);
                }).Start();
                
            }
        }
    }
}
