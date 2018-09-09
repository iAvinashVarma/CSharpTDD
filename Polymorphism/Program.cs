using Moq;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			const int hours = 55, wage = 70;
			var mock = new Mock<Utils>();
			mock.Setup(m => m.GetEmployees())
				.Returns(() => new List<IEmployee>
				{
					new Employee(),
					new Contractor()
				});
			List<IEmployee> employees = mock.Object.GetEmployees();
			employees.ForEach(e =>
			{
				Console.WriteLine("{0}{1}{0}", Environment.NewLine, e.CalculateWeeklySalary(hours, wage));
			});
		}
	}
}