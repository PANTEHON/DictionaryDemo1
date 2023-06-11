using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Batuhan");
            myDictionary.Add(2, "Zeynep");
            myDictionary.Add(3, "Mert");
            myDictionary.Add(4, "Semih");
            myDictionary.Add(5, "Asena");

            myDictionary.T1Id();

            myDictionary.T2Id();

            Console.WriteLine("Kişi sayısı : " + myDictionary.Count);

        }
    }
}
