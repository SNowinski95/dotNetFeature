//1 one using in all project
global using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 namespace barcket scoupe is full file
namespace test;

//Most important change in C#10
public static class C10
{
    //3 string interpolation in const
    public const string Example = "example";
    public const string Example2 = $"{Example}2";

    //fast lambda declaration
    public static void LambdaVarDeclaration()
    {
        var lambda = (string x) => true;
        //also you can set return type
        var lambda2 = bool? (string x) => true;
    }
    
}

//4 generic attribiute
public class ExampleAttribute<T> : Attribute
{
    public T GenericProp { get; init; }
}
//5 record struct
public record struct Record1(int x, int y);

//6 init value in struct constructor without params
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; } 
    public Point()
    {
        X = 0;
        Y = 0;
    }
}
