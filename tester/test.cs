using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using so_rt;
namespace tester
{
    [TestClass]
    public class test
    {


        [TestMethod]
        public void MyTestMethod()
        {
            bool actual = false;
            string[] xamp = { "afd", "abe", "adf", "cdf", "bad", "fad" };
            var test = new bubble_sort<string>();
            string[] expected = { "abe", "adf", "afd", "bad", "cdf", "fad" };
            test.one(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++) {
                if (expected[i] == xamp[i]) {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret,actual);

        }

        //int test
        [TestMethod]
        public void MyTestMethod2()
        {
            bool actual = false;
            int[] xamp = { 45, 23, 11, 89, 77, 98, 4, 28, 65, 43 };
            var test = new bubble_sort<int>();
            int[] expected = { 4, 11, 23, 28, 43, 45, 65, 77, 89, 98 };
            test.one(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);

        }

        //bool test
        [TestMethod]
        public void MyTestMethod3()
        {
            bool actual = false;
            bool[] xamp = { true, false, false, true, true, false, false, true, true };
            var test = new bubble_sort<bool>();
            bool[] expected = { false, false, false, false, true, true, true, true, true, };
            test.one(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);

        }
        //double test
        [TestMethod]
        public void MyTestMethod4()
        {
            bool actual = false;
            double[] xamp = { 1.2, 3.2, 1.1, 5.6, 4.67, 6.34, 2.23, 5.76, 9.6, 7.76, 45.4 };
            var test = new bubble_sort<double>();
            double[] expected = { 1.2, 3.2, 1.1, 5.6, 4.67, 6.34, 2.23, 5.76, 9.6, 7.76, 45.4 };
            test.one(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);

        }

        //merge sort tests

        //string test
        [TestMethod]
        public void MyTestMethod5()
        {
            bool actual = false;
            string[] xamp = { "afd", "abe", "adf", "cdf", "bad", "fad" };
            var test = new merge_sort<string>();
            string[] expected = { "abe", "adf", "afd", "bad", "cdf", "fad" };
            test.sort(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);


        }
        //int test
        [TestMethod]
        public void MyTestMethod6()
        {
            bool actual = false;
            int[] xamp = { 45, 23, 11, 89, 77, 98, 4, 28, 65, 43 };
            var test = new merge_sort<int>();
            int[] expected = { 4, 11, 23, 28, 43, 45, 65, 77, 89, 98 };
            test.sort(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);

        }
        //bool test
        [TestMethod]
        public void MyTestMethod7()
        {
            bool actual = false;
            bool[] xamp = { true, false, false, true, true, false, false, true, true };
            var test = new merge_sort<bool>();
            bool[] expected = { false, false, false, false, true, true, true, true, true, };
            test.sort(xamp);
            int j = 0;
            for (int i = 0; i < xamp.Length; i++)
            {
                if (expected[i] == xamp[i])
                {
                    j++;
                }

            }
            if (j == xamp.Length)
            {
                actual = true;
            }
            bool ret = true;
            Assert.AreEqual(ret, actual);

        }

    }

    public class Bubble_sort
    {
    }
}
