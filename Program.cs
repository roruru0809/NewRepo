// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

class Program
{
    static void Main()
    {

        Console.WriteLine("呼叫 MyHomeWork01:");
        MyHomeWork01();


        Console.WriteLine("呼叫 MyHomeWork02:");
        MyHomeWork02();
    }

    static void MyHomeWork01()
    {
        // 宣告陣列
        int[] intArray = new int[10];
        float[] floatArray = new float[8];
        double[] doubleArray = new double[4];
        string[] stringArray = new string[5];

        // 輸入整數陣列
        Console.WriteLine("請輸入 10 個整數：");
        for (int i = 0; i < 10; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        // 輸入浮點數陣列
        Console.WriteLine("請輸入 8 個浮點數：");
        for (int i = 0; i < 8; i++)
        {
            floatArray[i] = float.Parse(Console.ReadLine());
        }

        // 輸入倍精確度陣列
        Console.WriteLine("請輸入 4 個倍精確度數：");
        for (int i = 0; i < 4; i++)
        {
            doubleArray[i] = double.Parse(Console.ReadLine());
        }

        // 輸入字串陣列
        Console.WriteLine("請輸入 5 個字串：");
        for (int i = 0; i < 5; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        // 印出整數陣列及其平均值
        Console.WriteLine("整數陣列：");
        int intSum = 0;
        foreach (int num in intArray)
        {
            Console.Write(num + " ");
            intSum += num;
        }
        Console.WriteLine($"\n整數陣列平均值：{(double)intSum / intArray.Length}");

        // 印出浮點數陣列及其平均值
        Console.WriteLine("浮點數陣列：");
        float floatSum = 0;
        foreach (float num in floatArray)
        {
            Console.Write(num + " ");
            floatSum += num;
        }
        Console.WriteLine($"\n浮點數陣列平均值：{floatSum / floatArray.Length}");

        // 印出倍精確度陣列及其平均值
        Console.WriteLine("倍精確度數陣列：");
        double doubleSum = 0;
        foreach (double num in doubleArray)
        {
            Console.Write(num + " ");
            doubleSum += num;
        }
        Console.WriteLine($"\n倍精確度數陣列平均值：{doubleSum / doubleArray.Length}");

        // 印出字串陣列
        Console.WriteLine("字串陣列：");
        foreach (string str in stringArray)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }



    static void MyHomeWork02()
    {
        int[] 整數 = { 1, 2, 3, 4, 5 };

        double[] 浮點數 = { 1.2, 2.3, 3.4, 4.5, 5.6 };

        double[] 倍精確度數 = { 1.22, 2.33, 3.44, 4.55, 5.66 };

        string[] 字串 = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };



        Console.WriteLine("整數陣列：");
        int intSum = 0;
        foreach (int num in 整數)
        {
            Console.Write(num + " ");
            intSum += num;
        }
        Console.WriteLine($"\n整數陣列平均值：{(double)intSum / 整數.Length}");

        // 印出浮點數陣列及其平均值
        Console.WriteLine("浮點數陣列：");
        float floatSum = 0;
        foreach (float num in 浮點數)
        {
            Console.Write(num + " ");
            floatSum += num;
        }
        Console.WriteLine($"\n浮點數陣列平均值：{floatSum / 浮點數.Length}");

        // 印出倍精確度陣列及其平均值
        Console.WriteLine("倍精確度數陣列：");
        double doubleSum = 0;
        foreach (double num in 倍精確度數)
        {
            Console.Write(num + " ");
            doubleSum += num;
        }
        Console.WriteLine($"\n倍精確度數陣列平均值：{doubleSum / 倍精確度數.Length}");

        // 印出字串陣列
        Console.WriteLine("字串陣列：");
        foreach (string str in 字串)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}
   

