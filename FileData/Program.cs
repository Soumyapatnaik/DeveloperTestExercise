using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        
        public static void Main(string[] args)
        {            
            
            try
            {
                Boolean validValues;

                validValues = FileVersionAndSizeCheck(args[0], args[1]);
                
                if (validValues == false)
                {
                    Console.WriteLine("Wrong Input");
                    Console.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: ", e);
            }

        }
        public static Boolean FileVersionAndSizeCheck(string Functionality, string FileName)
        {
            Boolean validValues = false;
            try
            {
                
                string[] FileVersionValues = System.Configuration.ConfigurationSettings.AppSettings["FileVersion"].Split(',');

                FileDetails filedetails = new FileDetails();

                for (int fileVerCount = 0; fileVerCount < FileVersionValues.Length; fileVerCount++)
                {
                    if (Functionality.Equals(FileVersionValues[fileVerCount]))
                    {
                        Console.WriteLine(filedetails.Version(FileName));
                        validValues = true;                       
                        break;
                        
                    }
                }

                string[] FileSizeValues = System.Configuration.ConfigurationSettings.AppSettings["FileSize"].Split(',');

                
                for (int fileSizeCount = 0; fileSizeCount < FileSizeValues.Length; fileSizeCount++)
                {
                    if (Functionality.Equals(FileSizeValues[fileSizeCount]))
                    {
                        Console.WriteLine(filedetails.Size(FileName));
                        validValues = true;
                        break;

                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: ", e);
            }
            return validValues;

        }
        
    }
}
