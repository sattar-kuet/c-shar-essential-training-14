using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {500, 1, 2, 3,1 };
            numbers.Add(100);
            numbers.AddRange(new int[3] { 200,300,400});

            numbers.RemoveAt(0);
            for(int i=0; i< numbers.Count(); i = i + 1)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(1);
                }
                Console.WriteLine(numbers[i]);
            }

            int index = numbers.IndexOf(400);
            bool status =  numbers.Contains(300);
            Console.WriteLine(status);

        }
    }
}
