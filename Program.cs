using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine("BMI計算機");

                while (true)
                {
                    // 宣告變數 , 輸入身高體重
                    Console.Write("身高:");
                    float tall = float.Parse(Console.ReadLine()) / 100;

                    Console.Write("體重:");
                    float weight = float.Parse(Console.ReadLine());



                    // 宣告變數 , 以便儲存計算後數值
                    double BMI;

                    // 計算BMI
                    BMI = weight / (tall * tall);

                    {
                        if (BMI < 18.5)
                        {
                            Console.WriteLine("過輕囉拜託吃多點！");
                        }
                        else if (18.5 <= BMI && BMI < 24)
                        {
                            Console.WriteLine("體重適中！");
                        }
                        else if (24 <= BMI && BMI < 27)
                        {
                            Console.WriteLine("有點重ㄟ！");
                            Console.Beep(1000, 1000);
                        }
                        else if (27 <= BMI && BMI < 30)
                        {
                            Console.WriteLine("好胖！請注意飲食！");
                            Console.Beep(1000, 1000);
                        }
                        else if (30 <= BMI && BMI < 35)
                        {
                            Console.WriteLine("太重囉！！！快去運動！");
                            Console.Beep(1000, 1000);
                        }
                        else
                        {
                            Console.WriteLine("真的太重了！肥胖容易有心血管疾病，注意自己的健康！");
                            Console.Beep(1000, 1000);
                        }
                    }


                    // 顯示結果
                    Console.WriteLine("您的BMI指數為" + Math.Round(BMI, 1));
                    Console.ReadLine();
                }
            }
        }
    }
}
    
        
    

