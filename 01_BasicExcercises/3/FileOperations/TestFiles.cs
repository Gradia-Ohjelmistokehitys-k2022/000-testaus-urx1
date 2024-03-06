using System.Diagnostics.Metrics;
using System.Reflection;

/*
Tee uusi solution ja projekti nimeltään FileOperations. 
Lisää projektiin testiprojekti.
Tehtävänäsi on suunnitella kaksi testiä lisää alla olevalle ohjelmalle. 
Nyt testataan, onko listassa yhtään alkiota. Mitä muita testejä keksit?
*/

namespace TestFiles
{
    public class Files
    {

        public static void Main(string[] args)
        {
        }

        private static void PrintFile(List<string> systemConfig)
        {
            int counter = 0;

            foreach (var item in systemConfig)
            {
                Console.WriteLine(item);
                counter++;
            }
        }

        public static List<string> ReadFile(List<string> fileContent, string directory, string filePath)
        {


            StreamReader reader = new StreamReader(directory + filePath);
            try
            {
                while (reader.Peek() != -1) 
                {
                    fileContent.Add(reader.ReadLine()); //oma muuttuja ja if not null
                }
               // while (reader.Peek() != -1);
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch
            {
                fileContent.Add(("File is empty"));
            }
            finally
            {
                reader.Close();
            }            
            return fileContent;
        }
    }
}
