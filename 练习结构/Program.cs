using System;

namespace 练习结构
{
    class Program
    { 
        public enum Gender
        {
            男,
            女
        }
        public struct Person
        {
            public string _name;
            public int _age;
            public Gender _gender;
        }

            static void Main(string[] args)
            {
                //Mycolor color;
                //color._red = 255;
                //color._green = 0;
                //color._blue = 0;
                Person zs;
                zs._name = "张三";
                zs._gender = Gender.男;
                zs._age = 18;
                Person xl;
                xl._name = "小兰";
                xl._gender = Gender.女;
                xl._age = 16;
                Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生", zs._name, zs._age, zs._gender);
                Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生", xl._name, xl._age, xl._gender);
                Console.ReadKey();


            }
        
    }
}


