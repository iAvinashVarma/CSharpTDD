using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTest
{
	[TestClass]
	public class EmployeeTest
	{
		[TestMethod]
		public void CalculateWeeklySalaryForEmployeeTest_70Wage55HoursReturns2800Dollars()
		{
			// Arrange
			var weeklyHours = 55;
			int wage = 70;
			int salary = 40 * wage;
			IEmployee employee = new Employee();
			var expectedResponse = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			// Act
			var actualResponse = employee.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreEqual(expectedResponse, actualResponse);
		}

		[TestMethod]
		public void CalculateWeeklySalaryForContractorTest_70Wage55HoursReturns3850Dollars()
		{
			// Arrange
			var weeklyHours = 55;
			int wage = 70;
			int salary = weeklyHours * wage;
			IEmployee employee = new Contractor();
			var expectedResponse = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			// Act
			var actualResponse = employee.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreEqual(expectedResponse, actualResponse);
		}

		[TestMethod]
		public void CalculateWeeklySalaryForEmployeeTest_70Wage55HoursDoesNotReturnCorrectString()
		{
			// Arrange
			var weeklyHours = 55;
			int wage = 70;
			int salary = 1;
			IEmployee employee = new Employee();
			var expectedResponse = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			// Act
			var actualResponse = employee.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreNotEqual(expectedResponse, actualResponse);
		}

		[TestMethod]
		public void CalculateWeeklySalaryForContractorTest_70Wage55HoursDoesNotReturnCorrectString()
		{
			// Arrange
			var weeklyHours = 55;
			int wage = 70;
			int salary = 1;
			IEmployee employee = new Contractor();
			var expectedResponse = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			// Act
			var actualResponse = employee.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreNotEqual(expectedResponse, actualResponse);
		}
	}
}