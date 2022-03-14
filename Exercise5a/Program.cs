// See https://aka.ms/new-console-template for more information
/*
 Display intro
declare hourlyRate, regularhrs overtimehrs as double
prompt user for wage rate
read hourly rate

prompt user for overtime hours worked
read ovrtime hrs

calculate total weekly pay: (wage * regularHours) + (1.5 * wage * overtimeHours)
 */

Console.WriteLine("This program will display an employee's total weekly pay.\n\n");

double wage, regularHours, overtimeHours;
Console.Write("Enter hourly wage: ");

wage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter total number of regular hours: ");

regularHours = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter overtime hours: ");

overtimeHours = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The total weekly pay = $" + ((wage * regularHours) + (1.5 * wage * overtimeHours)));
