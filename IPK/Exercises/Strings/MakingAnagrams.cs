﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRank.IPK.Strings.Exercises
{
    class MakingAnagrams : IExercise
    {
        // Complete the makeAnagram function below.
        static int makeAnagram(string str1, string str2)
        {
            var letterArray = new int[27];
            foreach (var c in str1)
            {
                letterArray[c - 'a']++;
            }
            foreach (var c in str2)
            {
                letterArray[c - 'a']--;
            }

            return letterArray.Sum(e => Math.Abs(e));
        }



        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            string a = "fcrxzwscanmligyxyvym"; //Console.ReadLine();

            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";//Console.ReadLine();

            int res = makeAnagram(a, b);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
