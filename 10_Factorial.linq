<Query Kind="Statements" />

//Find the factorial of a numbers
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
	factorial *= i;
}
Console.WriteLine ("Factorial of {0} is {1}", number, factorial);