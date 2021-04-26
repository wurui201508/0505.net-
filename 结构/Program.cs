using System;

namespace 结构
{
    class Program
    {
        public struct Person
        {
            public string _name;//前面加public是为了后面能访问到后面的变量；
            public int _age;
            public char _gender;
        }
        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = '男';

                

        }
    }
}
