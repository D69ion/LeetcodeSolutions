using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Medium
{

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            BigInteger number1 = ListToNumber(l1);
            BigInteger number2 = ListToNumber(l2);
            BigInteger result = number1 + number2;

            return NumberToList(result);
        }

        private BigInteger ListToNumber(ListNode l1)
        {
            BigInteger result = 0;
            BigInteger multiplier = 1;
            ListNode? temp = l1;
            while (true)
            {
                if (temp != null)
                {
                    result += multiplier * temp.val;
                    multiplier = multiplier * 10;
                    temp = temp.next;
                }
                else break;
            }
            return result;
        }

        private ListNode NumberToList(BigInteger result)
        {
            string stringNumber = result.ToString();
            char[] chars = stringNumber.ToCharArray();
            Array.Reverse(chars);
            ListNode resultList = new ListNode();
            ListNode temp = resultList;
            for (int i = 0; i < chars.Length; i++)
            {
                temp.val = (int)Char.GetNumericValue(chars[i]);
                if (i != chars.Length - 1)
                {
                    temp.next = new ListNode();
                    temp = temp.next;
                }
                else temp.next = null;
            }
            return resultList;
        }
    }
}
