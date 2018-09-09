using System.Collections.Generic;

namespace Polymorphism
{
	public class Utils
	{
		public virtual List<IEmployee> GetEmployees()
		{
			IEmployee someEmployee = new Employee();
			IEmployee someContractor = new Contractor();
			return new List<IEmployee>
			{
				someEmployee,
				someContractor
			};
		}
	}
}