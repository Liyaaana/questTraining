using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string filePath = "C: \\Users\\liyan\\OneDrive\\Desktop";

            try
            {
                await Task.Delay(100); 

                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to access this file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An I/O error occurred while accessing the file.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }
    }
}