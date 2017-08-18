using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CSharp7._0Features
{
    class Program
    {
        static void Main(string[] args)
        {
            OutVariables();

            PatternMatching();

            Tuples();

            Print();

            LocalFunctions();

            ReferencesToElements();

            BinaryLiterals();
        }

        private static void BinaryLiterals()
        {
            int i = 123_234_1;
            WriteLine(i);
            int b = 0000_0001;
            WriteLine(b);
            int h = 0xFF;
            int valueOfCharF = 'f';
            WriteLine(valueOfCharF);
            WriteLine(h);
        }

        private static void ReferencesToElements()
        {
            int[] elements = { 1, 2, 3 };

            ref int refToEnd = ref elements[2];

            refToEnd = 4;

            WriteLine(string.Join(",",elements));
        }

        private static void LocalFunctions()
        {
            var area = CalculateArea(2);

            double CalculateArea(int length)
            {
                return Math.Pow(length, 2);
            }

            Console.WriteLine($"Area of Square is {area}");
        }

        private static void Tuples()
        {
            WriteLine("Examples of Tuples");
            WriteLine("------------------");

            //(string name, int age) = ("Ram", 23);
            var (name, age) = ("Ram", 23);
            WriteLine($"{name} {age}");

            var myInfo = (name: "Ram", age: 23, sex: "Male", city: "Hyderabad");
            WriteLine($"{myInfo.name} {myInfo.age} {myInfo.sex} {myInfo.city}");
            WriteLine(myInfo);
            WriteLine($"Type : {myInfo.GetType().Name}");
        }

        private static void Print() => WriteLine("This is Expression Bodied Member");

        private static void PatternMatching()
        {
            WriteLine("Examples of Pattern Matching");
            WriteLine("------------------");
            object value = new Program();
            switch (value)
            {
                case Int32 i when i == 10:
                    Console.WriteLine($"Value is 10");
                    break;
                case Int32 i:
                    Console.WriteLine($"Integer Value: {value}");
                    break;
                case String s:
                    Console.WriteLine($"String Value : {value}");
                    break;
                case DateTime dt:
                    Console.WriteLine($"DateTime Value : {value}");
                    break;
                case object o:
                    Console.WriteLine($"Object Value : {value}");
                    break;
                default:
                    Console.WriteLine($"Default Value : {value}");
                    break;
            }
        }

        private static void OutVariables()
        {
            WriteLine("Examples of Out Variables");
            WriteLine("------------------");
            var IsDate = DateTime.TryParse("12/13/2017", out var dt);
            Console.WriteLine($"Is it date? {IsDate}");
            Console.WriteLine($"Date : {dt}");
        }

        public override string ToString()
        {
            return base.GetType().Name.ToString();
        }
    }
}
