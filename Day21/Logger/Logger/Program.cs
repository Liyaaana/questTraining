using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;

namespace logger
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();

            try
            {
                Console.WriteLine("Enter num1: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2: ");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                log.Error(e.StackTrace);
            }
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newLine"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };
            var errorFileLogger = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error,
            };
            BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        }
    }
}
