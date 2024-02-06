using System.Reflection;

/*
Tee uusi solution ja projekti nimeltään FileOperations. 
Lisää projektiin testiprojekti.
Tehtävänäsi on suunnitella kaksi testiä lisää alla olevalle ohjelmalle. 
Nyt testataan, onko listassa yhtään alkiota. Mitä muita testejä keksit?
*/

namespace TestFiles
{
    public class File
    {

        public static void Main(string[] args)
        {
        }

        private static void PrintFile(List<string> systemConfig)
        {
            foreach (var item in systemConfig)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> ReadFile(List<string> fileContent, string directory, string filePath)
        {

            StreamReader reader = new StreamReader(directory + filePath);
            try
            {
                do
                {
                    fileContent.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch (FileNotFoundException e)
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
