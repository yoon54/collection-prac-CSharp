﻿using System;
using System.Collections.Generic;

namespace collection_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(String.Join(",",array));
            string[] names = new string[] {"Tim","Martin","Nikki","Sara"};
            Console.WriteLine(String.Join(",",names));
            Boolean[] array2 = new Boolean[] {true, false,true, false,true, false,true, false,true, false};
            Console.WriteLine(String.Join(",",array2));
            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Mint");
            iceCream.Add("Strawberry");
            iceCream.Add("Green Tea");
            Console.WriteLine(String.Join(",",iceCream));
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(String.Join(",",iceCream));
            Dictionary<string,string> profile = new Dictionary<string,string>();
            Random rand = new Random();
            for(int i = 0; i < names.Length; i ++)
            {
                profile.Add(names[i], iceCream[rand.Next(0,iceCream.Count)]);
            }
            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
