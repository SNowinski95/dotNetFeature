using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TupleAlias = (int A,int B);

namespace test
{
    internal class C12
    {
        public void test()
        {
            // #1 new constuructor 
            var x = new Eg("sth" ,2,3);
            // #2 simlyfier delariation of array
            int[] array = [1, 2, 3, 4, 5];
            // #4 default value for lambda
            var lambda = (int x = 2) => x * x;
            // #5 tuple alias
            var (a,b) = new TupleAlias(1, 2);
        }
        // #3 readonly ref
        public void test2(ref readonly int x)
        {
            //imposible to change x
            //x++;
            //why not just in? becouse in not give you reference
        }

    }
    
    //Name is readonly
    public class Eg(string name, int numberOne, int numberTwo)
    {
        public string Name => name;
        public int NumberOne => numberOne;
        public int NumberTwo => numberTwo;
    }

    public static class Iterception
    {
        //[InterceptsLocation()]

        public static void DoSth(this string eg)
        {
            Console.WriteLine("DoSth");
        }
    }
}
