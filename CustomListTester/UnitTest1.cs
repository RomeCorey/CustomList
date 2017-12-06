using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            ListForTesting<int> list = new ListForTesting<int>();
            int expectedInt = 2;
            list.Add(99);
            list.Add(2);

            Assert.AreEqual(expectedInt, list[1]);
        }

        public void AddStringToList()
        {
            
            ListForTesting<string> list = new ListForTesting<string>();
            string expectedString = "HelloWorld";
            
            list.Add("HelloWorld");
            list.Add("Goodbye");


        public void ListCountTest()
        {
            ListForTesting<int> list = new ListForTesting<int>() { 1, 2, 3 };
            int expectedCount = 3;
            
            int actualResult = list.Count;
            
            Assert.AreEqual(expectedCount, actualResult);        
        }


    }
}
