using System;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数演示程序");
            Console.WriteLine("=======================================");
            Student stu1 = new Student();
            stu1.ShowStudent();
            Student stu2 = new Student("0901","孟浩然",20);
            stu2.ShowStudent();
            Console.WriteLine();
        }
    }
}
