using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		public static Calculator Calculator { get; set; }

		[ClassInitialize]
		public static void ClassInitialize(TestContext testContext)
		{
			Calculator = new Calculator();
		}

		[TestCleanup()]
		public void Cleanup()
		{
			Calculator.Clear_click();
		}
		[TestMethod]
		public void TestMethod1()
		{
			Calculator.Three_click();
			Calculator.Four_click();
			Calculator.Plus_click();
			Calculator.Eight_click();
			Calculator.Equals_click();

			Assert.AreEqual(42,Calculator.Result);
		}
		[TestMethod]
		public void TestMethod5()
		{
			Calculator.Three_click();
			Calculator.Four_click();
			Calculator.Plus_click();
			Calculator.Eight_click();
			Calculator.Equals_click();

			Assert.AreEqual(42, Calculator.Result);
		}
		[TestMethod]
		public void TestMethod2()
		{
			Calculator.Three_click();
			Calculator.Four_click();
			Calculator.Minus_click();
			Calculator.Eight_click();
			Calculator.Equals_click();

			Assert.AreEqual(26, Calculator.Result);
		}
		[TestMethod]
		public void TestMethod3()
		{
			Calculator.Three_click();
			Calculator.Four_click();
			Calculator.Multiply_click();
			Calculator.Two_click();
			Calculator.Equals_click();

			Assert.AreEqual(68, Calculator.Result);
		}
		[TestMethod]
		public void TestMethod4()
		{
			Calculator.Three_click();
			Calculator.Six_click();
			Calculator.Divide_click();
			Calculator.Four_click();
			Calculator.Equals_click();

			Assert.AreEqual(9, Calculator.Result);
		}
	}
}
