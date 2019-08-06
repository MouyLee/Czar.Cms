using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorDemo
{
    class Student
    {
        public string ID; //学号
        public string Name;//姓名
        public int Age;    //年龄
        //无参构造方法
        public Student()
        {
            ID = "空";
            Name = "空";
            Age = 0;
        }
        //有参构造方法
        public Student(string id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        //显示字段信息
        public void ShowStudent()
        {
            Console.WriteLine("学号:{0},姓名:{1},年龄:{2}",ID,Name,Age);
        }

    }
}
