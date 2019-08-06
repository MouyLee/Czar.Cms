using System;
using System.IO;
using System.Text;

namespace FileStreamWriteDemo
{
    /// <summary>
    /// 2019-07-22
    /// LMM
    /// 字节流写文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字节流写文件演示程序");
            Console.WriteLine("=======================================");
            Console.WriteLine("请输入一段文本，同时按住Ctrl+Z结束：");
            string path = "E:\\MyProject\\PlanAries\\Aries\\Test\\test01.txt";    //包含完整路径名的文本文件名
            UnicodeEncoding ue = new UnicodeEncoding();

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                s += "\r\n";
                fs.Write(ue.GetBytes(s),0,ue.GetByteCount(s));
            }
            fs.Close();
            Console.WriteLine("文件写毕！");
        }
    }
}
