using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;


namespace CustomListTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex_Add()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedInt = 2;
            list.Add(99);
            list.Add(2);

            Assert.AreEqual(expectedInt, list[1]);
        }

        [TestMethod]
        public void AddStringToList()
        {

            CustomList<string> list = new CustomList<string>();
            string expectedString = "HelloWorld";

            list.Add("HelloWorld");
            list.Add("Goodbye");

            Assert.AreSame(expectedString, list[0]);

        }

        public void AddFloatToList()
        {
            CustomList<float> list = new CustomList<float>();
            float expectedFloat = 3.14f;

            list.Add(3.14f);
            
            Assert.AreEqual(expectedFloat, list[0]);
        }

        [TestMethod]
        public void AddNegativeNumberToList()
        {
            CustomList<int> list = new CustomList<int>();
            {
                int expectedNegative = -99;

                list.Add(23);
                list.Add(32);
                list.Add(-99);

                Assert.AreEqual(expectedNegative, list[2]);
            }
        }

        [TestMethod]
        public void ListCountTest()
        {
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int expectedCount = 2;
            
            int actualCount = list.Count;
            
            Assert.AreEqual(expectedCount, actualCount);        
        }

        [TestMethod]

        public void RemoveInt()
        {
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int expectedRemovedInt = 2;

            int actualRemoved = list.Remove[1];

            Assert.AreEqual(actualRemoved, expectedRemovedInt);

        }

        [TestMethod]

        public RemoveString()
        {
            CustomList<string> list = new CustomList<string>() { "Hello", "World", "Goodbye" };
            string expectedRemovedString = "World";

            string actualRemovedString = list.Remove[1];

            Assert.AreEqual(actualRemovedString, expectedRemovedString);

        }

        [TestMethod]

        public RemoveFloat() 
        {
            CustomList<float> list = new CustomList<float>() { 1, 3.14f, 44 };
            float expectedRemovedFloat = 3.14f;

            float actualRemovedFloat = list.Remove[3.14f];

            Assert.AreEqual(actualRemovedFloat, expectedRemovedFloat);

        }







    }
}
