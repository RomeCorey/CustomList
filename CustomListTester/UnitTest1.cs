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
            ListForTesting<int> list = new ListForTesting<int>();
            int expectedInt = 2;
            list.Add(99);
            list.Add(2);

            Assert.AreEqual(expectedInt, list[1]);
        }

        [TestMethod]
        public void AddStringToList()
        {

            ListForTesting<string> list = new ListForTesting<string>();
            string expectedString = "HelloWorld";

            list.Add("HelloWorld");
            list.Add("Goodbye");

            Assert.AreSame(expectedString, list[0]);

        }

        [TestMethod]
        public void ListCountTest()
        {
            ListForTesting<int> list = new ListForTesting<int>() { 1, 2, 3 };
            int expectedCount = 2;
            
            int actualCount = list.Count;
            
            Assert.AreEqual(expectedCount, actualResult);        
        }

        [TestMethod]

        public void RemoveInt()
        {
            ListForTesting<int> list = new ListForTesting<int>() { 1, 2, 3 };
            int expectedRemovedInt = 2;

            int actualRemoved = list.Remove[1];

            Assert.AreEqual(actualRemoved, expectedRemovedInt);

        }




    }
}
