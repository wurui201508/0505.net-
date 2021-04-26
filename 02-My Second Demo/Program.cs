using System;

namespace _02_My_Second_Demo
{
    class Program
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            //变量类型 变量名；
            //变量名=值；
            //100
            //官方语言：声明或者定义一个int类型的变量
            //int number;
            //官方语法：给这个变量进行赋值
            //number = 100;//表示把100存储到了这块空间内

            //double d = 3;
            //int number;//声明或者定义整数类型的变量；
            //number = 20;
            //Console.WriteLine(number);
            //Console.ReadLine();


            // string name = "李四";
            //Console.WriteLine("您好,"+name);
            //Console.ReadKey();

            //string name = "卡卡西";
            //int age = 30;
            //string email = "kakaxi@qq.com";
            //decimal salary = 5000m;
            //string addres = "火影村";
            //Console.WriteLine("我叫" + name + ",我住在" + addres + ",我今年" + age + "了，我的邮箱是" + email + ",我的工资是" + salary);


            ////int age = 18;
            ////age = 81;
            ////Console.WriteLine("原来你都" + age + "岁了呀");
            ////Console.ReadKey();
            //Console.WriteLine("我叫{0}，我住在{1}，我今年{2}了，我的邮箱是{3}，我的工资是{4}",name,addres,age,email,salary);
            //Console.ReadKey();

            // string name = "卡卡西";
            // char gender = '男';
            //string telephoneNumber = "010-18162110670";
            // int age = 18;
            // Console.WriteLine("我叫{0}，我今年{1}岁,我是{2}生，我的电话是{3}", name, age, gender, telephoneNumber);
            // Console.ReadKey();

            //int n1 = 10;
            //int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("交换后，n1的值是{0}，n2的值是{1}", n1, n2);
            //Console.ReadKey();

            //Console.WriteLine("你喜欢吃什么水果" );
            //Console.WriteLine(fruits);
            //Console.ReadKey("哈哈，这么巧，我也喜欢吃{1}", fruits);

            //Console.WriteLine("你喜欢吃什么水果");
            //string fruits = Console.ReadLine();//负责接收用户发送的信息
            //Console.WriteLine("哈哈，这么巧，我也喜欢吃{0}", fruits);
            //Console.ReadKey();

            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();

            //Console.WriteLine("请输入你的年龄");
            //    string age = Console.ReadLine();
            //Console.WriteLine("请输入你的性别");
            //string gender = Console.ReadLine();
            //Console.WriteLine("你好，{0}您的年龄是{1}，是个{2}生", name, age, gender);
            //Console.ReadKey();

            //Console.WriteLine("请输入\n你的姓名");
            //double Tshirt = 35;
            //double trousers = 120;
            //Console.WriteLine("一共{0}元，给你打8.88折，{1}元",3* Tshirt +2* trousers, (3*Tshirt +2* trousers) * 0.88);
            //Console.ReadKey();
            //int  n = 10;
            //int a = 3;
            //double c = n*1.0 / a;
            //Console.WriteLine("{1：0.00}", c);
            //Console.ReadKey();
            //bool a = 10 > 1 || 1 > 2;
            //Console.WriteLine(a);
            //Console.ReadKey();

            //Console.WriteLine("请输入你语文成绩");
            //int  chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入你音乐成绩");
            //int music = Convert.ToInt32(Console.ReadLine());

            //if (((chinese > 90 && music > 80) || (chinese == 100 && music > 70)) == true) //当语文成绩大于90 并且音乐成绩大于80
            //{
            //    Console.WriteLine("奖励100元");
            //}
            //else
            //{
            //    Console.WriteLine("不能吃饭");
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入你的成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score > 90)
            //{
            //    Console.WriteLine("a");
            //}
            //else if (score >= 80) 
            //{
            //    Console.WriteLine("b");
            //}
            // Console.WriteLine("请输入你的密码");
            //string pwd = Console.ReadLine();
            // if (pwd ==" 8888888") 
            // {
            //     Console.WriteLine("密码正确");
            // }
            // else
            // {
            //     Console.WriteLine("密码错误 请重新输入");
            //    pwd = Console.ReadLine();
            //     if (pwd=="8888888")
            //     {
            //         Console.WriteLine("输入两边终于对了");
            //     }
            //     else
            //     {
            //         Console.WriteLine("密码错误");
            //     }
            // }
            //bool b = true;
            //int number = 0;
            //Console.WriteLine("请输入一个数字");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());

            //}
            //catch { 
            //  Console.WriteLine("你输入的字符有错误");
            //    b = false;
            //}
            //if (b) 
            //{ 
            //Console.WriteLine(number * 2);
            //}
            //Console.ReadKey();




            ////请用户输入年份月份来
            //Console.WriteLine("请输入年份");
            //try
            //{

            //    int year = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        Console.WriteLine("请输入月份");
            //        int month = r(Console.ReadLine());
            //        if (month >= 1 && month <= 12)
            //        {
            //            int day = 0;//声明一个变量来存储天数
            //            switch (month)
            //            {
            //                //1 3 5 7 8 10 12 月都是31天
            //                case 1:
            //                case 3:
            //                case 5:
            //                case 7:
            //                case 8:
            //                case 10:
            //                case 12:day = 31;
            //                    break;
            //                case 2:
            //                  if ((year % 400 == 0) || (year % 4 == 0 && year % 100 == 0))//闰年的计算方式能被400整除 或者 被4并且被100整除
            //                    {
            //                        day = 29;
            //                    }
            //                    else
            //                    {
            //                        day = 28;
            //                    }

            //                    break;
            //                   default :
            //                    day = 30;//上面的都没有符合，那就是剩下的2 4 6 9 11月
            //                    break;
            //            }
            //            Console.WriteLine("{0}年{1}月{2}日", year, month, day);

            //        }


            //        else
            //        {
            //            Console.WriteLine("您输入的月份不符合");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("您输入的月份有误，请重新输入");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("您输入的年份有误");
            //}

            //Console.ReadKey();


            //int i = 0;
            //while(i<100)
            //{
            //    Console.WriteLine("下次考试我一定仔细{0}",i);
            //    i++;
            //}
            //Console.ReadKey();


            //string answer = "";
            //int i = 1;
            //while (answer != "yes" && i <=10)
            //{
            //    Console.WriteLine("这是我第{0}次教你,你会了吗？yes/no", i );
            //    answer = Console.ReadLine();
            //    if (answer == "yes")
            //    {
            //        Console.WriteLine("放学");
            //        break;
            //    }
            //    i++;
            //}
            //Console.ReadKey();

            //string name = "";
            //string password = "";
            //int n = 1;
            //while((name!="admin"||password!="password")&&n<=3)
            //{
            //    Console.WriteLine("请输入你的用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入你的密码");
            //        password = Console.ReadLine();
            //    n++;
            //}
            //Console.ReadKey();

            //name!=""

            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入你的名字");
            //    name = Console.ReadLine();
            //}
            //while (name != "q");

            //Console.ReadKey();
            //输入任意数字，计算它的两倍，输入q程序结束

            //int n = 1;
            //int sum = 0;
            //while (n <= 100)
            //{
            //    if (n % 7 == 0)
            //    {
            //        n++;
            //        continue;
            //    }
            //    sum += n;
            //    n++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();
            //int sum = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    int bai = i / 100;
            //    int shi = i % 100 / 10;
            //    int ge = i % 10;
            //    if (i == bai * bai * bai + shi * shi * shi + ge * ge * ge)
            //    {
            //        Console.WriteLine("水仙花数有{0}",i);
            //        sum += i;
            //    }
            //}
            //Console.ReadKey();
            //for (int i =1; i <=9; i++)
            //{
            //    for (int n = 1; n  <=i; n ++)
            //    {
            //        Console.Write("{0}*{1}={2}/t", n,i, n * i);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年纪", i + 1);
            //    try
            //    {
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        if (a >= 0 && a <= 100)
            //        {
            //            sum += a;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的数字大于100或者为负数，程序退出");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("你输入的年纪有误，程序退出");
            //        b = false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("总和为{0}", sum / 5);
            //}
            //Console.WriteLine();



            //为什么有枚举这个东西
            //xx大学管理系统
            //姓名 性别 年级 年龄 系别
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = nums[0];
            //int mix = nums[0];
            //int sum = 0;
            ////nums[0] = 1;
            ////nums[1] = 2;
            ////nums[2] =3;
            ////nums[3] = 4;
            ////nums[4] = 5;
            ////nums[5] = 6;
            ////nums[6] = 7;
            ////nums[7] = 8;
            ////nums[8] = 9;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < mix)
            //    {
            //        mix = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("数组的最大为{0}，最小值为{1}，总和为{2}，平均值为{3}", max, mix, sum, sum / nums.Length);
            //Console.ReadKey();
            //string[] _name = { "老杨", "老邹", "老苏", "老虎", "老牛", "老蒋", "老王", "老马" };
            //string k = null;
            //for (int i = 0; i < _name.Length-1; i++)
            //{
            //   k+=_name[i]+"丨";
            //}
            //Console.WriteLine(k +_name[_name.Length-1]);
            //Console.ReadKey();

            //int[] nums = { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i <nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] +=1;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }
            //    else
            //    {

            //    }
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();
            //string[] n = { "我", "是", "好人" };
            //for (int i = 0; i < n.Length/2; i++)
            //{
            //    string temp = n[i];
            //    n[i] = n[n.Length - 1 - i];
            //    n[n.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < n.Length; i++)
            //{
            //    Console.WriteLine(n[i]);
            //}
            //Console.ReadKey();

            int[] n = { 8, 1, 2, 3, 4, 5, 6, 7, 0 };
            for (int i = 0; i < n.Length - 1; i++)
            {
                for (int t = 0; t < n.Length - 1 - i; t++)
                {
                    if (n[t] > n[t + 1])
                    {
                        int temp = n[t];
                        n[t] = n[t + 1];
                        n[t + 1] = temp;
                    }
                }

            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadKey();
        }
    }
    
}
