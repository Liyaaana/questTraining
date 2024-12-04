using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashOfFile
{
    class Program
    {
        /*
        static void Main()
        {

            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string hash = CalculateFileHash(filePath);
                Console.WriteLine($"SHA256 Hash: {hash}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static string CalculateFileHash(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }
    }
}
*/
        static void Main()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(desktop, "MusicFiles", "music1.mp3");
            var bufferedStream = new BufferedStream(File.OpenRead(path), 1024);
            var checkSum = new SHA256CryptoServiceProvider().ComputeHash(bufferedStream);
            var output = BitConverter.ToString(checkSum).Replace("-", "");
            bufferedStream.Close();
            Console.WriteLine($"Hash is {output}");
        }
    }
}