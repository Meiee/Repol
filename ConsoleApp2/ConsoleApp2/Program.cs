using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2

{
    public class Program
    {
        //static void IsLeapYear(double a, double b, double c)
        //{
        //    Console.WriteLine($"Сторона a ={a} Сторона b { b} Сторона c ={c}");
        //    //Console.WriteLine("Сторона a ="+ a+ "Сторона b ="+ b+ "Сторона c ="+ c );
        //    //string txt=Console.ReadLine();
        //    // //a=double.Parse(txt);
        //    // //txt=Console.ReadLine();
        //    // b = double.Parse(txt);
        //    //txt=Console.ReadLine();
        //    //c = double.Parse(txt);
        //    if ((a == b) && (b == c))
        //    {
        //        Console.WriteLine("Треугольник равносторонний");

        //    }
        //    else
        //        Console.WriteLine("Треугольник  не равносторонний");
        //}

        //static void Function(string txtOne, string txtTwo)
        //{
        //    Console.WriteLine($"строка = {txtOne} строка = {txtTwo}");
        //}

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите еще одну строку");
        //    string txt_Two = Console.ReadLine();

        //    Function(txt_Two, "122121");
        //    Function(Console.ReadLine(), "122121");


        //Console.WriteLine("Введите строку");
        //string sent = "";
        //for (; ; )
        //{

        //    Console.WriteLine("Bвeдитe строку");
        //    string line = Console.ReadLine();

        //    string[] terms = { "exit", "e" };

        //    bool quit = false;
        //    foreach (string term in terms)
        //    {

        //        if (String.Compare(line, term) == 0)
        //        {
        //            quit = true;
        //        }
        //    }
        //    if (quit == true)
        //    {
        //        break;
        //    }

        //    sent = String.Concat(sent, line);

        //    Console.WriteLine("\nBы ввели : " + sent);
        //}
        //Console.WriteLine(" \nПолучилось: \n" + sent);

        //IsLeapYear(12, 11, 14);
        //Console.WriteLine("vvedite b");
        //string txt = Console.ReadLine();
        //double b = double.Parse(txt);
        //IsLeapYear(11, b, 11);

        static void IsLeapYear(int x)
        { 
        Console.WriteLine("Введите год");
            Console.ReadLine();
            if (x % 4 == 0)
            {
                Console.WriteLine("Год високосный");
            } 
            else 
            {
                Console.WriteLine("Год обычный");
            };

        }
    }
}