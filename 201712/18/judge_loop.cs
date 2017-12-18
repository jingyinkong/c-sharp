using System;

namespace JudgeApplication
{
    class Judge
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                /* 如下写法在C#中是可以的。
                 * 注意：C#中不允许从一个case继续执行到另一个case，如果case语句中有处理语句，则必须包含break或者其他处理语句。 */
                case 1:
                case 2:
                    Console.WriteLine("case 2 num is {0}", num);
                    break;
                case 3:
                    Console.WriteLine("case 3 num is {0}", num);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}