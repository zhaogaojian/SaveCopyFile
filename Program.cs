using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SaveCopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcDir = args[0];
            string srcFile = args[1];
            string destDir = args[2];
            string tempPath=srcFile.Replace(srcDir, "");
            try
            {
                File.Copy(srcFile, destDir + tempPath,true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
