using System;
using System.IO;

namespace StreamReaderDemo
{
    /// <summary>
    /// 2019-07-22
    /// LMM
    /// 字符流读文本文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StreamReader 类演示程序");
            Console.WriteLine("=======================================");
            string filename = "E:\\MyProject\\PlanAries\\Aries\\Test\\test.txt";    //包含完整路径名的文本文件名
            StreamReader sr = new StreamReader(filename);
            string s;
            while ((s=sr.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            Console.WriteLine("文件读毕");
            Console.WriteLine();
            /*
             创建StreamReader类对象，除了调用StreamReader类的构造方法以外，还有两种方法：
             一、通过FileInfo类创建
             FileInfo fi=new FileInfo(filename);
             StreamReader sr=fi.OpenText();
             二、通过File类创建
             StreamReader sr=File.OpenText(fileName);
             */
        }
    }
}
