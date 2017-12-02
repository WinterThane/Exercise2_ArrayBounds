using System;

namespace Exercise2_ArrayBounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Array.CreateInstance(typeof(String), 6);
            stringArray.SetValue("One", 0);
            stringArray.SetValue("Two", 1);
            stringArray.SetValue("Three", 2);
            stringArray.SetValue("Four", 3);
            stringArray.SetValue("Five", 4);
            stringArray.SetValue("Six", 4);

            Console.WriteLine("Array lower bound is: {0}", stringArray.GetLowerBound(0).ToString());
            Console.WriteLine("Array upper bound is: {0}", stringArray.GetUpperBound(0).ToString());
            Console.ReadLine();
        }
    }
}
