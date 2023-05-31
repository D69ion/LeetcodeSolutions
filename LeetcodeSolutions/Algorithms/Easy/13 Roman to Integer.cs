using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Easy
{
    //https://leetcode.com/problems/roman-to-integer/description/
    public class Roman
    {
        int _originalSize;
        string IV = "IV"; //4
        string IX = "IX"; //9
        string XL = "XL"; //40
        string XC = "XC"; //90
        string CD = "CD"; //400
        string CM = "CM"; //900
        public int RomanToInt(string s)
        {
            _originalSize = s.Length;
            int sum = 0;
            s = s.Replace(IV, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 4;
                _originalSize = s.Length;
            }
            s = s.Replace(IX, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 9;
                _originalSize = s.Length;
            }
            s= s.Replace(XL, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 40;
                _originalSize = s.Length;
            }
            s=s.Replace(XC, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 90;
                _originalSize = s.Length;
            }
            s = s.Replace(CD, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 400;
                _originalSize = s.Length;
            }
            s = s.Replace(CM, String.Empty);
            if (s.Length != _originalSize)
            {
                sum += (_originalSize - s.Length) / 2 * 900;
                _originalSize = s.Length;
            }


            for (int i = 0; i < s.Length; i++)
            {
                sum += RomanToDecimal(s[i]);
            }

            return sum;
        }

        private int RomanToDecimal(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }
    }
}
