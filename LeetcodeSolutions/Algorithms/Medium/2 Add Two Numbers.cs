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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    //https://leetcode.com/problems/add-two-numbers/description/
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
            BigInteger result = l1.val;
            BigInteger multiplier = 1;
            ListNode temp = l1.next;
            while (true)
            {
                if (temp != null)
                {
                    multiplier = multiplier * 10;
                    result += multiplier * temp.val;
                    temp = temp.next;
                }
                else break;
            }
            return result;
        }

        private ListNode NumberToList(BigInteger result)
        {
            /*
            string stringNumber = result.ToString().Reverse().ToString()!;
            ListNode resultList = new ListNode(stringNumber[0]);
            ListNode node = new ListNode();
            foreach (var number in stringNumber)
            {
                
            }
            return resultList;*/


            string stringNumber = result.ToString().Reverse().ToString()!;
            ListNode resultList = new ListNode();
            int index = 0;
            IntToNode(resultList, stringNumber, index);
            return resultList;
        }

        private void IntToNode(ListNode resultList, string data, int index)
        {
            resultList.val = Convert.ToInt32(data[index++]);
            if (index < data.Length)
            {
                ListNode listNode = new ListNode();
                resultList.next = listNode;
                IntToNode(resultList.next, data, index);
            }
        }
    }
}
