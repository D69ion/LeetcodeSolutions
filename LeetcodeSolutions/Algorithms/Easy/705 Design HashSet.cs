using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.Algorithms.Easy
{
    public class MyHashSet
    {
        int[] _values;
        bool[] _isFilled;

        public MyHashSet()
        {
            _values = new int[5];
            _isFilled = new bool[5];
        }

        public void Add(int key)
        {
            if(!Contains(key))
            {
                if (!TryAdd(key))
                {
                    //extending arrays
                    int[] temp = new int[_values.Length * 2];
                    Array.Copy(_values, temp, _values.Length);
                    _values = temp;
                    bool[] bools = new bool[temp.Length];
                    Array.Copy(_isFilled, bools, _isFilled.Length);
                    _isFilled = bools;

                    TryAdd(key);
                }
            }
        }

        private bool TryAdd(int key)
        {
            for (int i = 0; i < _isFilled.Length; i++)
            {
                if (!_isFilled[i])
                {
                    _values[i] = key;
                    _isFilled[i] = true;
                    return true;
                }
            }
            return false;
        }

        public void Remove(int key)
        {
            for (int i = 0; i < _values.Length; i++)
            {
                if (_isFilled[i] && _values[i] == key)
                {
                    _values[i] = 0;
                    _isFilled[i] = false;
                    return;
                }
            }

        }

        public bool Contains(int key)
        {
            for (int i = 0; i < _values.Length; i++)
            {
                if (_isFilled[i] && _values[i] == key)
                    return true;
            }
            return false;
        }
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */