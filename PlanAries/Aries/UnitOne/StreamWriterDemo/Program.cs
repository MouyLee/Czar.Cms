using System;
using System.IO;

namespace StreamWriterDemo
{
    /// <summary>
    /// 2019-07-22
    /// LMM
    /// 字符流写入文本文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StreamWriter 类演示程序");
            Console.WriteLine("=======================================");
            string filename = "E:\\MyProject\\PlanAries\\Aries\\Test\\test.txt";    //包含完整路径名的文本文件名
            StreamWriter sw = new StreamWriter(filename);
            Console.WriteLine("请输入一段文本，同时按住Ctrl+Z结束：");
            string s;
            while ((s=Console.ReadLine())!=null)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            Console.WriteLine("文件写毕");

            /*
             创建StreamWriter类对象，除了调用StreamWrite类的构造方法以外，还有两种方法：
             一、通过FileInfo类创建
             FileInfo fi=new FileInfo(filename);
             StreamWriter sw=fi.CreateText();
             二、通过File类创建
             StreamWriter sw=File.CreateText(fileName);
             */
        }
    }
}
