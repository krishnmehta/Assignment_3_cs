using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Dictionary with key = integer and value = string
            Dictionary<int, string> Primeminister  = new Dictionary<int, string>();

            //Adding elements in dictionary
            Primeminister.Add(1998,"Atal Bihari Vajpayee");
            Primeminister.Add(2014, "Narendra Modi");
            Primeminister.Add(2004, "Manmohan Singh");

            //Find the prime minister of 2004
            if(Primeminister.TryGetValue(2004,out string value))
            {
                Console.WriteLine("Prime Minister of the year 2004 is: "+value);
            }
            else
            {
                Console.WriteLine("No PrimeMinister found");
            }

            //Adding Primeminister of current year
            Primeminister[DateTime.Now.Year] = "Narendra Modi";

            //Sorting the dictionary by year
            Console.WriteLine("\nSorted by Year");
            Console.WriteLine("=============");
            foreach(KeyValuePair<int,string> prime in Primeminister.OrderBy(x => x.Key))
            {
                Console.WriteLine(prime.Key+" "+prime.Value);
            }
            Console.WriteLine("=============");
        }
    }
}