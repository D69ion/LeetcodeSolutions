using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Medium
{
    internal class _7_Reverse_Integer
    {
        public int Reverse(int x)
        {
            bool isNegative = x < 0;

            char[] chars = x.ToString().ToCharArray();
            Array.Reverse(chars);
            string reversedX = new string(chars);
            reversedX = reversedX.Replace("-", "");

            if (Int32.TryParse(reversedX, out int result))
            {
                return isNegative switch
                {
                    true => result * -1,
                    false => result
                };
            }
            return 0;
        }
    }
}
