using System;

/*  在 C# 中，变量分为以下几种类型：
 * 
 *  值类型（Value types）
 *  引用类型（Reference types）
 *      对象类型：Object     编译时进行类型检查。
 *      动态类型：dynamic    运行时进行类型检查。
 *      字符串类型：string
 *  指针类型（Pointer types） 
 */

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 布尔值 */
            Console.WriteLine("Size of bool: {0}", sizeof(bool));

            /* 8 位无符号整数 */
            Console.WriteLine("Size of byte: {0}", sizeof(byte));

            /* 16 位 Unicode 字符 */
            Console.WriteLine("Size of char: {0}", sizeof(char));

            /* 128 位精确的十进制值，28-29 有效位数   */
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));

            /* 64 位双精度浮点型    */
            Console.WriteLine("Size of double: {0}", sizeof(double));

            /* 32 位单精度浮点型    */
            Console.WriteLine("Size of float: {0}", sizeof(float));

            /* 32 位有符号整数类型   */
            Console.WriteLine("Size of int: {0}", sizeof(int));

            /* 64 位有符号整数类型   */
            Console.WriteLine("Size of long: {0}", sizeof(long));

            /* 8 位有符号整数类型    */
            Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));

            /* 16 位有符号整数类型   */
            Console.WriteLine("Size of short: {0}", sizeof(short));

            /* 32 位无符号整数类型   */
            Console.WriteLine("Size of uint: {0}", sizeof(uint));

            /* 64 位无符号整数类型   */
            Console.WriteLine("Size of ulong: {0}", sizeof(ulong));

            /* 16 位无符号整数类型   */
            Console.WriteLine("Size of ushort: {0}", sizeof(ushort));


            /* 对象类型：Object */
            Object obj;         /* Object类型，分配在堆上。 */
            int i = 5;          /* int类型，分配在栈上。 */
            obj = i;            /* int→Object：装箱。 */
            int j = (int)obj;   /* Object→int：拆箱。 */

            /* 动态类型：dynamic */
            dynamic d = 20;

            /* 字符串类型：string */
            string str_1 = "c-sharp-study";
            /* @(逐字字符串)相当于Python中的r,表明后边的字符串不进行转义。 */
            string str_2 = @"F:\code\c-sharp\201712\18";

            Console.ReadLine();
        }
    }
}