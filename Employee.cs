namespace EmployeeRegister
{
	class Employee
	{
		public string Name { get; set; }
		public int Salary { get; set; }

		public Employee()
		{
			Name = "";
			Salary = 0;
		}

		public Employee(string name, int salary)
		{
			Name = name;
			Salary = salary;
		}
	}
}