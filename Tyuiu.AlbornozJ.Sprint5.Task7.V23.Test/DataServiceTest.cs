using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint5.Task7.V23.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V23.txt";

            
            string resultFile = ds.LoadDataAndSave(path);

            
            Assert.IsTrue(File.Exists(resultFile));
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
