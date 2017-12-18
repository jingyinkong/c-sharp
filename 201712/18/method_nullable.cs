using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        /* 引用参数，注意声明方式为：ref <value_type> <value_name>; */
        public void swap(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
        }

        /* 输出参数，可以用来从函数中返回多个返回值。 */
        public void getValue(out int x, out int y)
        {
            x = 99;
            y = 100;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int x = 5, y = 12;
            n.swap(ref x, ref y);
            /* C#中的print format方法，结合了Python中的.format及C/C++风格的格式化方法。其中{}中必须按顺序填写值。 */
            Console.WriteLine("x = {0}, y = {1}", x, y);    


            n.getValue(out x, out y);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            /* 可空类型（nullable）。即在原有类型基础上，追加null值。
             * 例如数据库中的Boolean值，除了False、True，还有可能是NULL，在代码中取得数据库对应值的时候，就可以用可空类型。 */
            int? num = null;                                
            Console.WriteLine("num = {0}", num);

            double? num1 = null;
            double? num2 = 3.14;
            double num3, num4;

            /* null合并运算符。
             * 如果第一个操作数为null，则返回第二个操作数的值， 否则返回第一个操作数的值。 */
            num3 = num1 ?? 5.1;
            num4 = num2 ?? 5.1;
            Console.WriteLine("num3 = {0}, num4 = {1}", num3, num4);


            Console.ReadKey();

        }
    }

}