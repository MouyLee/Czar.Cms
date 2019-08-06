using System;
using System.IO;
using System.Text;

namespace FileStreamReadDemo
{
    /// <summary>
    /// 2019-07-23
    /// LMM
    /// 字节流读文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字节流读文件演示程序");
            Console.WriteLine("=======================================");
            string path = "E:\\MyProject\\PlanAries\\Aries\\Test\\test01.txt";    //包含完整路径名的文本文件名
            UnicodeEncoding ue = new UnicodeEncoding();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            int nBytes = 100;
            byte[] buf = new byte[nBytes];
            int count;
            while ((count=fs.Read(buf,0,nBytes))>0)
            {
                Console.Write(ue.GetString(buf,0,count));
            }
            fs.Close();
            Console.WriteLine();
        }
    }
}
