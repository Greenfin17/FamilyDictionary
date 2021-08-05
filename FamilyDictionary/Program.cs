using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n     Family Dictionary");
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister1", new Dictionary<string, string>() {  { "name", "Nancy" }, { "relation", "sister" }, { "age", "52" } });
            myFamily.Add("sister2", new Dictionary<string, string>() { { "name", "Krista" }, { "relation", "sister" }, { "age", "54" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Roger" }, { "relation", "brother" }, { "age", "60" } });

            Console.WriteLine("     A listing of family members\n");
            int index;

            foreach(var (sibling, info) in myFamily)
            {
                index = 0;
                foreach(var (key, definition) in info)
                {
                    switch(index)
                    {
                        case 0:
                            Console.Write($"     {definition} is my ");
                            index++;
                            break;
                        case 1:
                            Console.Write($"{definition} ");
                            index++;
                            break;
                        case 2:
                            Console.Write($"and is {definition} years old.\n");
                            index++;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}
