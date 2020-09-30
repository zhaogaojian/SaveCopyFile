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
                string destDir = args[i];
                string tempPath = srcFile.Replace(srcDir, "");
                try
                {
                    string destFile = destDir + tempPath;
                    if (destFile == srcFile) continue;//目标目录中修改自己不拷贝
                    string destFileDirectory=Path.GetDirectoryName(destFile);
                    if (!Directory.Exists(destFileDirectory))
                    {
                        Directory.CreateDirectory(destFileDirectory);
                    }
                    File.Copy(srcFile, destFile, true);
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
            
        }
    }
}
