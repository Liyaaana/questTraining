using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlternateLogger
{
    internal class Program
    {
        static void Action1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"Action 1 : {DateTime.Now}");
        }
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console(
                restrictedToMinimumLevel: LogEventLevel.Information,
                outputTemplate: "[{Timestamp} {Level:u3} {Message} {NewLine}]")
                .CreateLogger();

            logger.Information("Appliction Started");

            var ci = new CultureInfo("en-IN");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            //var date = DateTime.Now;
            //Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine($"Main : {DateTime.Now}");

            var t = new Thread(Action1);
            t.Start();

            // currency
            var cu = new CultureInfo("en-GB");
            var price = 100.5626161;
            var formattedPrice = price.ToString("C", cu);
            var formattedPriceTwoDecimal = price.ToString("F2");
            var roundedPrice = price.ToString("G4");
            Console.WriteLine(formattedPrice);
            Console.WriteLine(formattedPriceTwoDecimal);
            Console.WriteLine(roundedPrice);

        }
    }
}