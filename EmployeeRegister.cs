namespace EmployeeRegister
{
	class EmployeeRegister
	{
		public List<Employee> employees;

		public EmployeeRegister()
		{
			employees = new List<Employee>();
		}

		public void Add(Employee e)
		{
			employees.Add(e);
		}

		public void PrintEmployeeRegister()
		{
			foreach (Employee e in employees)
			{
				Console.WriteLine($"Name: {e.name}, Salary: {e.salary}");
			}
		}
	}
}
