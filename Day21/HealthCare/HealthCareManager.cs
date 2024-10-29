using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net;

namespace HealthCare
{
    internal class HealthCareManager
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HealthCareManager));
        private DataStore _store;

        public HealthCareManager()
        {
            _store = new DataStore();
            ConfigureLogging();
        }

        public void ListUpcomingAppointmentsInNextSevenDays()
        {
            try
            {
                var result = _store.Appointments
                    .Where(a => a.AppointmentDate >= DateTime.Now && a.AppointmentDate <= DateTime.Now.AddDays(7))
                    .Join(_store.Patients,
                        a => a.PatientId,
                        p => p.Id,
                        (a, p) => new
                        {
                            Name = p.Name,
                            Age = p.Age,
                            MedicalCondition = p.MedicalCondition,
                            AppointmentDate = a.AppointmentDate,
                        }
                    );

                Console.WriteLine("Appointments in next seven days:");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Name}, {item.Age}, {item.MedicalCondition}, {item.AppointmentDate}");
                }
            }
            catch (Exception ex)
            {
                // Log the error to the file and console
                log.Error("An error occurred while listing upcoming appointments.", ex);
                Console.WriteLine("An error occurred. Please check the log file for details.");
            }
        }

        public void PatientsWithMostAppointmentsInLastThirtyDays()
        {
            try
            {
                var lastThirtyDays = DateTime.Now.AddDays(-30);
                var patientAppointmentCounts = _store.Appointments
                    .Where(a => a.AppointmentDate >= lastThirtyDays && a.AppointmentDate <= DateTime.Now)
                    .GroupBy(a => a.PatientId)
                    .Select(g => new { PatientId = g.Key, Count = g.Count() })
                    .OrderByDescending(g => g.Count)
                    .ToList();

                var maxAppointmentCount = patientAppointmentCounts.First().Count;
                var mostActivePatientDetails = patientAppointmentCounts
                    .Where(p => p.Count == maxAppointmentCount)
                    .Join(_store.Patients,
                        p => p.PatientId,
                        m => m.Id,
                        (p, m) => new
                        {
                            Name = m.Name,
                            Age = m.Age,
                            MedicalCondition = m.MedicalCondition
                        }
                    ).ToList();

                Console.WriteLine("Most active patients:");
                foreach (var item in mostActivePatientDetails)
                {
                    Console.WriteLine($"{item.Name}, {item.Age}, {item.MedicalCondition}");
                }
            }
            catch (Exception ex)
            {
                // Log the error to the file and console
                log.Error("An error occurred while finding patients with the most appointments.", ex);
                Console.WriteLine("An error occurred. Please check the log file for details.");
            }
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [thread] %-5level %logger - %message%newline"
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
                Threshold = Level.Error
            };

            BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        }
    }
}
