// See https://aka.ms/new-console-template for more information


Console.WriteLine("This program will display an employee's total weekly pay.\n\n");

double wage, regularHours, overtimeHours;
Console.Write("Enter hourly wage: ");

wage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter total number of regular hours: ");

regularHours = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter overtime hours: ");

overtimeHours = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The total weekly pay = $" + ((wage * regularHours) + (1.5 * wage * overtimeHours)));
