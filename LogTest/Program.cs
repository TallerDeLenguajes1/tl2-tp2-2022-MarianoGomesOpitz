// See https://aka.ms/new-console-template for more information
using System;
using NLog;


namespace LogTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetCurrentClassLogger();

            log.Trace("Mensaje de Trace");
            log.Debug("Mensaje de Debug");
            log.Info("Mensaje de Info");
            log.Warn("Mensaje de Warn");
            log.Error("Mensaje de Error");
            log.Fatal("Mensaje de Fatal");
        }
    }
}