namespace Polymorphism
{
	public class Employee : IEmployee
	{
		public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
		{
			var salary = 40 * wage;
			var result = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			return result;
		}
	}

	public class Contractor : Employee
	{
		public override string CalculateWeeklySalary(int weeklyHours, int wage)
		{
			var salary = weeklyHours * wage;
			var result = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs." +
						$"Paid for 40 hrs at ${wage}" +
						$"/hr = ${salary}";
			return result;
		}
	}
}