using System;
using System.IO;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DirectoryInfo类演示程序");
            Console.WriteLine("=======================================");

            string srcDirName = "e:\\我的作品\\文章"; //源目录
            string destDirName = "e:\\Alice"; //目标目录

            DirectoryInfo dir1 = new DirectoryInfo(srcDirName);  
            DirectoryInfo dir2 = new DirectoryInfo(destDirName);

            if (dir1.Exists)
            {
                dir1.Delete(true);
            }
            dir1.Create();
            dir1.CreateSubdirectory("散文");
            dir1.CreateSubdirectory("小说");
            //
            if (dir2.Exists)
            {
                dir2.Delete(true);
            }
            dir1.MoveTo(destDirName);
            DirectoryInfo[] dis = dir2.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Console.WriteLine(di.FullName);
            }

            FileInfo[] fis = dir2.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine(dir2.CreationTime.ToString());
            Console.WriteLine(dir2.LastWriteTime.ToString());
            Console.WriteLine(dir2.LastAccessTime.ToString());
            Console.WriteLine(dir2.FullName);
            Console.WriteLine(dir2.Root);

        }
    }
}
