using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTasks
{
    internal class OpeningFile
    {


        public static void openFile(String filePath)
        {
            try
            {
                using (FileStream fileStream = File.Open(filePath, FileMode.Open))
                {
                    
                    Console.WriteLine("File opened successfully.");
                    
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access to the file is denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while opening the file: " + ex.Message);
            }
        }
    }
}
