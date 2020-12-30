using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace ConsoleAppLog4Net
{
    class Program
    {

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            Console.WriteLine("Hello world!");

            // Log some things
            log.Info("Hello logging world!");
            log.Error("Error!");
            log.Warn("Warn!");

        }
    }
}
