﻿using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");


            string hash5 = hash.Get("5");
            Console.WriteLine("5th Index Value: " + hash5);


        }
    }
}
