using System;
using CalcLib;
using CalcLibTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibTests
{
    [TestClass]
    public class CalcTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", "Server = .\\SQLEXPRESS;Integrated Security = True;Database = Mod_for_calculator", "TestData", DataAccessMethod.Sequential)]
       // [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Mod_for_calculator.mdf;Integrated Security=True;Connect Timeout=30", "TestData", DataAccessMethod.Sequential)]


        


        [TestMethod]

        public void Calc_Mod_FromDB()
        {
            double a = (double)TestContext.DataRow["a"];
            double b = (double)TestContext.DataRow["b"];
            string r = (string)TestContext.DataRow["r"];
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
