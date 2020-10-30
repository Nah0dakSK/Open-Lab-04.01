using System;
using System.Collections.Generic;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            var str = "hello llama";
            var chars = str.ToCharArray();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            foreach(var ch in chars)
            {
                if(charDictionary.ContainsKey(ch)
                {
                charDictionary[ch] = charDictionary[ch] + 1;
                }
                else
                {
                charDictionary.Add(ch, 1);
                }

            }
            var keys = new HashSet<char>(charDictionary.Keys);
            foreach(var ch in keys)
            {
                if(charDictionary[ch] > 1)
                {
                 Console.WriteLine($"Character {ch} repeating {charDictionary[ch]} times.");
                }

            } 
            Console.ReadKey();
        }
    }
}
