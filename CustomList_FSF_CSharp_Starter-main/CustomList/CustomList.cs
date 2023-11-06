using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of bounds");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of bounds");
                }
                items[index] = value;
            }

        }
        public int Count
        {
            get { return count; }
        }
        public int Capacity
        {
            get { return capacity; }
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            items[count]= item;
            count++;
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array

            if (count == capacity)
            {
                capacity *= 2;
                T[] TempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    TempArray[i] = items[i];
                }
                items = TempArray;
            }
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            if (items.Contains(item))
            {
                T[] TempArray = new T[capacity];
                for (int i = 1; i < count; i++)
                {
                    TempArray[i - 1] = items[i];
                }
                count--;
                items = TempArray;
                return true;
            }
            else
            {
                return false;
            }
            
            //Any items coming after the removed item should be shifted down so there is no empty index.

            //If 'item' was removed, return true. If no item was removed, return false.
            
        }

        public override string ToString()
        {
            //returns a single string that contains all items from arra

            string result = string.Join(",", items);
            Console.WriteLine(result);
            return result;


        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 

            string CombineList = firstList.items + secondList.items;
            return new CustomList<T>();
           
            
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
