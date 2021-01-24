using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("table","masa");
            dictionary.Add("book","kitab");
            dictionary.Add("student","telebe");
           // dictionary.Insert(2,"teacher","muellim");
           dictionary.DeleteByKey("student");
            Console.WriteLine(dictionary.Count);
            foreach (var dictionaryKey in dictionary.Keys)
            {
                Console.WriteLine(dictionaryKey);
            }


        }
    }
}
