using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Dec(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            //return a / b;
            
             if (b!=0)
            {
                  return a / b;
            }
           
            else
             {
                  Console.WriteLine("除数不能为零");
                  return 0;
              }
        }
        static void Main(string[] args)
        {
        }
    }
}
