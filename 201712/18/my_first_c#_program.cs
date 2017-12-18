using System;                               // 类似于Python中的import。如果不写这行，则输出语句：System.Console.WriteLine();

namespace HelloWorldApplication             // 命名空间，其中可以包含若干个class
{
    class HelloWorldApplication             // class声明
    {
        static void Main(string[] args)     // 每个class必须有一个Main函数
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();              // 等待一个按键动作，防止CMD窗口快速运行并关闭。
        }
    }
}