using System;
using System.Collections.Generic;
using System.Data;
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
     * Standard Methods (use the methods that you already defined them before)
     *  - Insert(int index, item): insert item at arr[index]
     *  - IndexOf(item): return index of item or -1 if not exist
     *  - Contains(item): False/True
     *  - Remove(item): remove first occurence of item
     *  - RemoveAll(item): remove all occurrence of item
     *  - Clear(): remove all Elements and reinitialize Count, Capacity
     *  - ToString(): clean string representation "[1, 2, 3, 4]"
     *  
     * Make it generic array
     * 
     * Advanced Features:
     *  - Implement IEnumerable<T>
     *  - Implement  IComparable<T>: 
     *      -Sort(): Implement a sorting algorithm (like Bubble Sort or Insertion Sort for practice) to sort the elements in place.
     *  - Reverse()
     *  
     */

    // Dynamic Array
    public class MyArray<T>
    {
        T[] data;
        int size;
        int index;

        public int Count => index;
        public int Capacity => size;

        public MyArray(int intialCapacity)
        {
            data = new T[intialCapacity];
            size = intialCapacity;
            index = 0;            
        }

        public MyArray()
        {
            data = new T[4];
            size = 4;
            index = 0;
        }

        public void Add(T value)
        {
            if (index >= size)
            {
                extend();
            }

            data[index++] = value;
        }

        public T this[int i]
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

        public void Insert(int i, T value)
        {
            //(-1)
            // 0 1  2  3 4 5 6
            // 2 3  4  5 6 7 _
            // 2 3 -1  4 5 6 7 _

            if (i <= index && i >= 0)
            {
                if (index >= size)
                {
                    extend();
                }

                T temp = default;
                T temp2 = default;

                for (int j = i; j < index; j++)
                {
                    temp = data[j];
                    if (j == i)
                    {
                        temp2 = data[j];
                        data[j] = value;
                        continue;
                    }

                    data[j] = temp2;
                    temp2 = temp;
                }
                data[index++] = temp;
            }
        }

        void extend()
        {
            T[] temp = new T[size + 4];

            for (int i = 0; i < size;  i++)
            {
                temp[i] = data[i];
            }
            data = temp;
            size += 4;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[");

            for (int i = 0; i < Count; i++)
            {
                sb.Append($"{data[i]}");
                if (i != (Count - 1))
                    sb.Append(", ");
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}
