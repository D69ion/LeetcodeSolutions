using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Easy
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string s = x.ToString();
            StringBuilder reversed = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Append(s[i]);
            }
            string s1 = reversed.ToString()!;
            return s.Equals(s1);
        }
    }
}
