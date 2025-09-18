using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Implementation.ArrayImplementation
{

    /*
     * Core Functionality:
     *  - Add(item), Get(item)Indexer, RemoveAt(i), Count
     * 
     * 
     * 
     * 
     */

    // Dynamic Array
    public class MyArray
    {
        int[] data;
        int size;
        int index;

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
