using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNew
{
    internal class LC1768
    {
        public static void main(string[] args)
        {

        }
        public string MergeAlternately(string word1, string word2)
        {
            //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string
            //Return the merged string.
            string mergedWrod = string.Empty;
            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                mergedWrod += (i < word1.Length ? word1[i] : "");
                mergedWrod += (i < word2.Length ? word2[i] : "");
            }
            return mergedWrod;
        }
    }
}
