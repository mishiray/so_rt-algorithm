using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so_rt
{
    /// <summary>
    /// class bubble_sort that contains bubble sorting algorithm 
    /// </summary>
    /// <typeparam name="T">Generic type T that extends icomparable interface</typeparam>
    public class Bubble_sort<T> : IComparable<T>
        where T : IComparable<T>
    {
        
        /// <summary>
        /// Bubble sort algorithm
        /// </summary>
        /// <param name="arr">This is the variable as a parameter that'll pass the array value into the method</param>
        /// <returns>An array arr thats already sortef</returns>
        public void one(T[] arr) {

            for (int i = 0; i < arr.Length-1; i++ ) {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int x = Compare(arr[j], arr[j + 1]);
                    if (x>0)
                    {
                        T t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }

                }
            }
        }

        /// <summary>
        /// Comapare method that extensively compares generic objects
        /// </summary>
        /// <param name="x">takes the first obj to compare</param>
        /// <param name="y">takes the second obj to compare</param>
        /// <returns>this returns 0,1,-1 depending on compare result</returns>
        public static int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }

        /// <summary>
        /// CompareTo method
        /// </summary>
        /// <param name="other">Other oj=bject to compare</param>
        /// <returns>returns void</returns>
        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
