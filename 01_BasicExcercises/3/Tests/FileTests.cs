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
            List<string> systemConfig;
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = Files.ReadFile(systemConfig, windir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count < 0); //tarkoituksella väärin. Korjaa.

        }

    }
}