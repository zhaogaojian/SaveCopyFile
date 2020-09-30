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
            //支持多个目标文件夹
            for (int i = 2; i < args.Length; i++)
            {
                string destDir = args[2];
                string tempPath = srcFile.Replace(srcDir, "");
                try
                {
                    if(!Directory.Exists(destDir))
                    {
                        Directory.CreateDirectory(destDir);
                    }
                    File.Copy(srcFile, destDir + tempPath, true);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
    }
}
