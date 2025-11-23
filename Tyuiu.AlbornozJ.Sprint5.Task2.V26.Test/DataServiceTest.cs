
using System.IO;
using Tyuiu.AlbornozJ.Sprint5.Task2.V26.Lib;

namespace Tyuiu.AlbornozJ.Sprint5.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 2, -3, -3 },
                                          { -8, 8, 0 },
                                          { -6, 1, 0 } };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
