using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using ConsoleApp1;
namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
        [TestMethod]
        public void IsNull()
        {
            Assert.IsNull(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10)); // так нада
        }
        [TestMethod]
        public void InRange()
        {
            Assert.AreEqual(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10), 4);
        }
        [TestMethod]
        public void Throws()
        {
            ConsoleApp1.Program program = new ConsoleApp1.Program();

            //exception = IndexOutOfRangeException;
            //Assert.ThrowsException(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10), "dfsfsd",program.exception) ;
        }
        [TestMethod]
        public void IsType()
        {
            //Type type = new Type();
            //Assert.IsInstanceOfType(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10), expectedType: );
        }
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(Convert.ToBoolean(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10)));
        }
        [TestMethod]
        public void IsFalse()
        {
            Assert.IsFalse(Convert.ToBoolean(class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10))); 
        }
    }
}
