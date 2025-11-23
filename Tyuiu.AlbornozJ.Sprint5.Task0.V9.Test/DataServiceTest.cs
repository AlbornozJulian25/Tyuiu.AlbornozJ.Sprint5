
using System.IO;

using Tyuiu.AlbornozJ.Sprint5.Task0.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
                        
            string path = ds.SaveToFileTextData(3);
                        
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
