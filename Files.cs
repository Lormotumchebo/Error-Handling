using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    internal class Files
    {
        
public class FileReader
    {
        public static string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public static void ReadLineByLine(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

   
}
}
