using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod]        
        public void MainTest()
        {
           Program.FileVersionAndSizeCheck("-v", "c:/test.txt");            
            
        }
        public void MainTest1()
        {
            Program.FileVersionAndSizeCheck("--v", "c:/test.txt");

        }
        public void MainTest2()
        {
            Program.FileVersionAndSizeCheck("/v", "c:/test.txt");

        }
        public void MainTest3()
        {
            Program.FileVersionAndSizeCheck("version", "c:/test.txt");

        }
        public void MainTest4()
        {
            Program.FileVersionAndSizeCheck("-s", "c:/test.txt");

        }
        public void MainTest5()
        {
            Program.FileVersionAndSizeCheck("--s", "c:/test.txt");

        }
        public void MainTest6()
        {
            Program.FileVersionAndSizeCheck("/s", "c:/test.txt");

        }
        public void MainTest7()
        {
            Program.FileVersionAndSizeCheck("size", "c:/test.txt");

        }


    }
}