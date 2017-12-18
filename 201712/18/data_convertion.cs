using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            /* 强制转换 double 为 int */
            i = (int)d;
            Console.WriteLine(i);

            /* C#内置类型转换方法，例如：ToString()、ToInt32()等。 */
            Console.WriteLine(d.ToString());

            /* Console.ReadLine()类似于Python中的input()，只能接受字符串类型。 */
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            Console.ReadKey();

        }
    }
}