using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace test;

//Most important change in C#11
public static class C11
    {
    //1
    public static void StringChanges()
    {
        //to use " inside the string you need only """ on start and on the end
        var x = """sth "sdt""";
        //for more " inside a row add more on start and end
        var y = """"sth """sdt"""";
        //this also working wth new line and interpolation (but with $$ and {{}}) eg. for json
        var z = $$"""
                {
                        "qwe": "{{x
                            .ToLower()}}"
                }
                """;
        
    }
    //2 checking and asigne from array
    public static void listPattern()
    {
        var array = new[] { 1, 2, 3, 4, 5 };
        if (array is [0 or 1, >= 2, ..])
        {
            //
        }
        
        if (array is [var first, .. var rest]) ;

        var sth = array switch
        {
            [] => 0,
            [var newValue] => 1,
            [var newValue1, .. var newValue2] => 2,
        };
    }

    //4 utf shortcut
    public static void utf()
    {
        var x = "xyz"u8;
    }
    //5 INumber to math operation 
    public static T Add<T>(T[] array) where T : INumber<T>
    {
        return array.Aggregate(T.Zero, (current, item) => current + item);
    }
    //9 
    public static void MethodLambdaConvertion()
    {
        var collection = new [] { 1, 2, 3 };
        var filtered = collection.Where(ExampleMethod);
    }
    public static bool ExampleMethod(int x) => true;

}
//7 file access
file class HelpClassC11
{
    //3 attributes have more scope
    [Description(nameof(sth))]
    public void Sth(int sth)
    {
    }
    //6 required operator
    public required int Id { get; init; }  //init ref to c# 9
}
//8
public struct Point2
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point2()
    {
        //x and y are default value and you have not do anything
    }
}

