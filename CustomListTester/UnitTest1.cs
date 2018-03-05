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
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedInt = 2;

            //act
            list.Add(99);
            list.Add(2);
            //assert
            Assert.AreEqual(expectedInt,  list[1]);
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
                int expectedNegative = -1;

                list.Add(1);
                list.Add(2);
                list.Add(-1);

                Assert.AreEqual(expectedNegative, list[2]);
            }
        }

        [TestMethod]
        public void ListCountTest()
        {
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int expectedCount = 3;
            
            int actualCount = list.Count;
            
            Assert.AreEqual(expectedCount, actualCount);        
        }

        [TestMethod]

        public void RemoveInt()
        {
            CustomList<int> list = new CustomList<int>() { 10, 20, 30 };
            int expectedCount = 2;

            list.Remove(10);

            Assert.AreEqual(list.Count, expectedCount);

        }

        [TestMethod]

        public void RemoveString()
        {
            CustomList<string> list = new CustomList<string>() { "Hello", "World", "Goodbye" };
            int expectedCount = 2;

            list.Remove("Hello");

            Assert.AreEqual(list.Count, expectedCount);

        }

        [TestMethod]

        public void RemoveFloat() 
        {
            CustomList<float> list = new CustomList<float>() { 1, 3.14f, 44 };
            int expectedFloat = 2;

            list.Remove(3.14f); 

            Assert.AreEqual(list.Count, expectedFloat);

        }
        







    }
}
