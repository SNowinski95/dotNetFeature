using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //Most important change in C#9
    public static class C9
    {
        //2 shortcut to create object without var
        //1 example of declaration
        public static void NewShortcut()
        {
            HelpClassC9 example = new() { Id = 1 };
        }
        //3 swich condition with connection
        public static string ConditionSwitch(int value)
        {
            return value switch
            {
                > 100 => "a lto",
                > 20 and < 100 => "well",
                0 or < 0 => "zero",
                _ => "impossible"
            };
        }
        //4 is not
        public static void IsNot()
        {
            HelpClassC9 example = null;
            if (example is not null)
            {
                //do sth
            }
        }
    }
    public class HelpClassC9
    {
        //1 init. You can assigne only in constructor or when you create the object
        public int Id { get; init; }
    }

    //sth like a immutable class but with comparation like a value object 
    //there is a lot function and specify behavior
    //look at with oparotr
    public record Record(int valueOne, string valueTwo);
}
