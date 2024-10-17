using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\user\Documents\TestDirectory";
            var filename = "data.txt";
            var filePath = Path.Combine(path, filename);
            // Directory.CreateDirectory(path);
            // File.Create(filePath);
            // File.WriteAllText(filePath, "New text from code");
            // File.AppendAllText(filePath, "New text from code");
            // File.AppendAllText(filePath, "New text from code");
            // File.AppendAllText(filePath, "New text from code");
            // Directory.Delete(path);
            // Directory.Delete(path, true);
            var content = File.ReadAllText(filePath);
            string[] contentLines = File.ReadAllLines(filePath);
            Console.WriteLine(content);
        }
    }
}
