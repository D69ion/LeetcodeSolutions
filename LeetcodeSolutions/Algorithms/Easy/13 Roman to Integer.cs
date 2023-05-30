using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Easy
{
    public class Roman
    {
        int _index = 1;
        public int RomanToInt(string s)
        {
            int sum = RomanToDecimal(s[0]);

            for (; _index < s.Length; _index++)
            {

                sum += RomanToDecimal(s[_index]);
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
