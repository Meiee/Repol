using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2

{
    public class Program
    {
        public static void main(int x)
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


            Console.WriteLine("Haжмитe <Enter> для  завершения программы...");
            Console.Read();
        }
    }
        
    
}