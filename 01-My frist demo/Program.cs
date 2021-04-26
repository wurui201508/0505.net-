using System;

namespace _01_My_frist_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "卡卡西";
            char gender = '男';
            string telephoneNumber = "010-18162110670";
            int age = 18;
            Console.WriteLine("我叫{0}，我今年{1}岁,我是{2}生，我的电话是{3}", name, age, gender, telephoneNumber);
            Console.ReadKey();

            string answer = "";
            int i = 0;
            while (answer != "yes" && i < 10)
            {
                Console.WriteLine("这是我第{0}次教你,你会了吗？yes/no", i + 1);
                answer = Console.ReadLine();
                i++;
            }
            Console.WriteLine("放学");
            Console.ReadKey();
        }
    }
}
