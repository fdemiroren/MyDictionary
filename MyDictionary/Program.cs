using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> standing = new MyDictionary<string, int>();
            standing.Add("Real Madrid", 15);
            standing.Add("Chelsea", 13);
            standing.Add("Basel", 4);
            standing.Add("D.Kiev", 1);

            Console.WriteLine("Takım Sayısı :" + standing.Length);

            Console.WriteLine("1. {0}, Puan :{1}",standing.Tkeys[0],standing.TValues[0]);
            Console.WriteLine("2. {0}, Puan :{1}", standing.Tkeys[1], standing.TValues[1]);
            Console.WriteLine("3. {0}, Puan :{1}", standing.Tkeys[2], standing.TValues[2]);
            Console.WriteLine("4. {0}, Puan :{1}", standing.Tkeys[3], standing.TValues[3]);

        }
    }
}
