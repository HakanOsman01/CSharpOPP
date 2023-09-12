namespace Database.Tests
{
    using Microsoft.VisualBasic;
    using NUnit.Framework;
    using System;
    using System.Threading;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new int[] {1,2,3,4,5,6})]
        [TestCase(new int[0] {})]
        [TestCase(new int[] {1})]
        [TestCase(new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16})]
        public void When_Constructor_Shoud_Create_Data(int[]parameturs)
        {
           Database database = new Database(parameturs);
            //Assert
            Assert.AreEqual(parameturs.Length,database.Count);

        }
        [TestCase(new int[] {1,2},new int[] {10,15},4)]
        [TestCase(new int[0] {},new int[] {int.MinValue,int.MaxValue,69},3)]

        public void Add_With_ValidData(int[] constructorArray, int[]parametursAdd,int expectedCount)
        {
            Database database=new Database(constructorArray);
            for (int i = 0; i < parametursAdd.Length; i++)
            {
                database.Add(parametursAdd[i]); 

            }
            Assert.AreEqual(expectedCount,database.Count);
        }
        [Test]
        public void Add_With_Invalid_Data()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 
                12, 13, 14, 15, 16);
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(9);
            });

        }
        [Test]
        public void Add_With_Correct_Count()
        {
            Database database = new Database(1, 2, 3);
            database.Add(4);
            int[] dataCopy = database.Fetch();

            Assert.AreEqual(dataCopy.Length, database.Count);

        }
        [Test]
        public void Does_Remove_Throws_InvalidOperation_Exception()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });

        }
        [Test]
        public void Does_Remove_Correct_Last_Element()
        {
            Database database = new Database(1,2,3,4,5,6,7,8,9,10);
            database.Remove();
            int[]arrrayCopy=database.Fetch();
            Assert.AreEqual(arrrayCopy.Length, database.Count);
        }
        [TestCase(new int[] {1,2,3,4,5,6,7,8})]
        [TestCase(new int[0] {})]
        [TestCase(new int[1] {3})]
        public void Test_Fetch_Does_Copy_The_Database_Correct(int[]data)
        {
            Database database = new Database(data);
            int[]databaseCopy=database.Fetch();
            CollectionAssert.AreEqual(databaseCopy, data);
        }
        [Test]
        public void Test_Does_Count_Decrease_When_Removes()
        {
            Database database=new Database(1,2,3);
            database.Remove();
            int[]copyDatabase=database.Fetch();
            Assert.AreEqual(copyDatabase.Length, database.Count);

        }
        [Test]
        public void Test_Does_Count_Increase_When_Adds()
        {
            Database database = new Database(1, 2, 3);
            database.Add(int.MinValue);
            int[] copyDatabase = database.Fetch();
            Assert.AreEqual(copyDatabase.Length, database.Count);

        }
        [Test]
        public void Test_Does_Count_Equal_To_Lenght()
        {
            Database database = new Database(1, 2, 3,10,101,69);
            int[] copyDatabase = database.Fetch();
            Assert.AreEqual(copyDatabase.Length, database.Count);

        }




    }
}
