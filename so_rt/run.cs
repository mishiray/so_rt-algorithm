using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so_rt
{
    /// <summary>
    /// class run is the main class that tests the different sorting algorithms
    /// </summary>
    public class Run
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Main method</param>
        public static void Main(String[] args) {

            int[] xamp = { 45, 23, 11, 89, 77, 98, 4, 28, 65, 43 };
            Bubble_sort<int> vote = new Bubble_sort<int>();

            vote.one(xamp);
            int[] x = xamp;

            foreach (int i in x) {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
