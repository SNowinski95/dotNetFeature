using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    //Most important change in C#8

    //1
    //readyonly method in structure 
    //you cant change props inside this method
    public struct Squear
    { 
        public int x { readonly get; set; }

        public readonly int Field => x * x; 
    }
    //2
    //basic implementation for interface
    public  interface IC8 : IDisposable
    {
         void DoSth() { Console.WriteLine("sth"); }
    }
    public static class C8 
    {
        //3
        //Switch Expression
        public static double SwitchExpressionCalculateExample(double x, double y, Calcuation operation)
        {
            return operation switch
            {
                Calcuation.plus => x + y,
                Calcuation.minus => x - y,
                Calcuation.divide => x / y,
                Calcuation.mulitply => x * y,
                _ => throw new Exception("bad operation")
            };
        }
        //4 using statement without bracked
        //2 using default implementation for interface
        public static void UsingDeclaration()
        {
            using IC8 dummy =  new HelpClassC8();
            dummy.DoSth();
            //now is dispose
        }
        //5 new iteration option
        public static int NewIteration()
        {
            var intArray = new int[] {1,2,3,4,5};
            //iterate from last. in this case start from 1;
            var lastItemInCollection = intArray[^1];
            Console.WriteLine("iteration [2..^0]");
            foreach (var item in intArray[2..^0]) //iterate from 2nd item (3) and stop until space after last item 
            {
                Console.WriteLine(item); // res: 3 4 5
            }
            Console.WriteLine("iteration [2..^1]");
            foreach (var item in intArray[2..^1])
            {
                Console.WriteLine(item); // res: 3 4
            }
            Console.WriteLine("iteration [..^1]");
            foreach (var item in intArray[..^1])
            {
                Console.WriteLine(item); // res:1 2 3 4
            }
            Console.WriteLine("iteration [2..]");
            foreach (var item in intArray[2..])
            {
                Console.WriteLine(item); // res: 3 4 5
            }
            return intArray[^2];//secound item form end (4)
        }
        //6 null assigment
        public static void AssigneIfNull(HelpClassC8 example)
        {
            //shortcut to example = example ?? new HelpClass();
            example ??= new HelpClassC8();
        }
    }

    public enum Calcuation
    {
        plus,
        minus,
        divide,
        mulitply
    }
    public class HelpClassC8 : IC8
    {
        public void Dispose()
        {
            //dispouse logic
        }
    }
}
