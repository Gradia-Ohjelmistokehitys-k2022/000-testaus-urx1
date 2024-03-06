using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;
using TestFiles;

namespace FileTests
{
    [TestClass]
    public class FileUnitTests
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
        {
            //Arrange
            List<string> systemConfig = new List<string>();
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = Files.ReadFile(systemConfig, winDir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count > 0);            
        }

        [TestMethod]
        public void ReadFile_ListCount_IsCorrect()
        {
            int expected = 13;

            //Arrange
            List<string> systemConfig = new List<string>();
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = Files.ReadFile(systemConfig, winDir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count == expected); 
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))] //JATKA
        public void ReadFile_ThrowsException_IfStringIsWrong()
        {
            //Arrange
            List<string> systemConfig = new List<string>();

            string winDir = "C:\\Winbdows";
            string path = "\\system.inni";

            //Act
            if (winDir == "C:\\Windows" && path == "\\system.ini")
            {
                systemConfig = Files.ReadFile(systemConfig, winDir, path);
            }
            else
            {
                throw new Exception("winDir or path is wrong.");
            }
        }
    }
}