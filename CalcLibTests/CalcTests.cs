using System;
using CalcLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibTests
{
    [TestClass]
    public class CalcTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", "Server = .\\SQLEXPRESS;Integrated Security = True;Database = Mod_for_calculator", "TestData", DataAccessMethod.Sequential)]

        [TestMethod]

        public void Calc_Mod_FromDB()
        {
            double a = Convert.ToDouble(TestContext.DataRow["a"]);
            double b = Convert.ToDouble(TestContext.DataRow["b"]);
            double r = Convert.ToDouble(TestContext.DataRow["r"]);
            double actual;
           
          
                actual = Calc.Mod(a, b);
                Assert.AreEqual(r, actual);
           
        }


        [TestMethod]
        public void Mod_10mod3_1returned()
        {
            
            //AAA
            //Arrange
            double a = 10;
            double b = 3;
            double expected = 1;
            //Actual
            double actual = Calc.Mod(a, b);
            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
