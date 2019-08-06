using System;
using System.IO;
using System.Text;

namespace EncodingDemo
{
    /// <summary>
    /// 2019-07-22
    /// LMM
    /// 关于字符编码的问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encoding 类演示程序");
            Console.WriteLine("=======================================");
            string filename = "E:\\MyProject\\PlanAries\\Aries\\Test\\test.txt";    //包含完整路径名的文本文件名
            StreamWriter sw = new StreamWriter(filename,true,Encoding.UTF8);
            Console.WriteLine("请输入一段文本，同时按住Ctrl+Z结束：");
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            Console.WriteLine("文件写毕");

            /*
             public StreamWriter(string path,bool append,Encoding encoding)
             bool类型的append参数确定是否将数据追加到文件中，如果该文件存在，并且append为true,则数据将被追加到该文件中；如果append为false，则该文件被覆盖；如果该文件部存在，则创建新文件
             */
        }
    }
}
