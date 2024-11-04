using System;
using System.Collections;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");
            arrayList.Add(42); // ArrayList can hold different data types

            Console.WriteLine("ArrayList Contents:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Using Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Apple", 1);
            dictionary.Add("Banana", 2);
            dictionary.Add("Cherry", 3);

            Console.WriteLine("\nDictionary Contents:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.ReadLine();
        }
    }
}
