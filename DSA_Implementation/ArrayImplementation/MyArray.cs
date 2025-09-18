using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Implementation.ArrayImplementation
{

    /*
     * Core Functionality:
     *  - Add(item), Get(item)Indexer,
     *  - Count(return number of elements), capacity(return size of array)
     *  - RemoveAt(i), Count 
     * 
     */

    // Dynamic Array
    public class MyArray
    {
        int[] data;
        int size;
        int index;

        public int Count => index;
        public int Capacity => size;

        public MyArray()
        {
            data = new int[4];
            size = 4;
            index = 0;
        }

        public void Add(int value)
        {
            if (index >= size)
            {
                extend();
            }

            data[index++] = value;
        }

        public int this[int i]
        {
            get 
            { 
                if (i < index && i >= 0)
                {
                    return data[i];
                }

                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveAt(int i)
        {
            if (i < index && i >= 0)
            {

                index--;

                for (int j = i; j < index ; j++)
                {
                    data[j] = data[j + 1];
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        void extend()
        {
            int[] temp = new int[size + 4];

            for (int i = 0; i < size;  i++)
            {
                temp[i] = data[i];
            }
            data = temp;
            size += 4;
        }
    }
}
