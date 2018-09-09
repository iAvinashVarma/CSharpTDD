using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTest
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void AnnualSalaryTest()
		{
			// Arrange
			var sc = new SalaryCalculator();
			// Act
			decimal annunalSalary = sc.GetAnnualSalary(50);
			// Assert
			Assert.AreEqual(104000, annunalSalary);
		}

		[TestMethod]
		public void HourlyWageTest()
		{
			// Arrange
			var sc = new SalaryCalculator();
			// Act
			decimal hourlyWage = sc.GetHourlyWage(52000);
			// Assert
			Assert.AreEqual(25, hourlyWage);
		}
	}
}