namespace EmployeeRegister
{
	//Test
	class Program
	{
		static void Main(string[] args)
		{
			// Driver code
			EmployeeRegister employees = new EmployeeRegister();
			string userMenuInput = "";

			Console.WriteLine("Hello, Welcome to the Employee Register system 1.0");

			while (userMenuInput != "9")
			{
				Console.WriteLine("1) To add a new employee select 1 and hit enter");
				Console.WriteLine("2) To print the current list of all employees select 2 and hit enter");
				Console.WriteLine("9) Enter 9 to exit application");
				userMenuInput = Console.ReadLine(); // get user menu choice 

				// Add new employee 
				if (userMenuInput == "1")
				{
					try
					{
						Console.WriteLine("Enter name");
						string inputName = Console.ReadLine();

						Console.WriteLine("Enter salary (only numbers)");
						int salary = int.Parse(Console.ReadLine());

						// Create new employee object
						employees.Add(new Employee(inputName, salary));
					}
					catch (Exception ex)
					{
						Console.WriteLine("Something wrong with your input, please follow input rules");
						Console.WriteLine($"Error message: {ex.Message}");
					}
				}
				// Print employee list
				else if (userMenuInput == "2")
				{
					Console.WriteLine("Full list of current employees");
					employees.PrintEmployeeRegister();
				}
				else if (userMenuInput == "9")
				{
					Console.WriteLine("Exiting application..");
				}
				// Invalid input from user
				else
				{
					Console.WriteLine("Invalid input, please try again");
				}
			}
		}
	}
}