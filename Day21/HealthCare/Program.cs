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

namespace HealthCare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //new HealthCareManager().ListUpcomingAppointmentsInNextSevenDays();
            HealthCareManager manager = new HealthCareManager();

            Console.WriteLine("Upcoming Appointments in the Next Seven Days:");
            manager.ListUpcomingAppointmentsInNextSevenDays();

            Console.WriteLine("\nPatients with Most Appointments in the Last Thirty Days:");
            manager.PatientsWithMostAppointmentsInLastThirtyDays();

        }
    }
}

