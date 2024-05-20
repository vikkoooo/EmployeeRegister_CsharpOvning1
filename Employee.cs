namespace EmployeeRegister
{
	class Employee
	{
		public string name { get; set; }
		public int salary { get; set; }

		public Employee()
		{
			name = "";
			salary = 0;
		}

		public Employee(string name, int salary)
		{
			this.name = name;
			this.salary = salary;
		}
	}
}