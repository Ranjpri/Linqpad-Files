<Query Kind="Statements" />

//a C# function to accept 2 integers and return remainder
Console.WriteLine("Enter 2 numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
try 
{
	int remainder = a % b;
	Console.WriteLine("Reminder of {0} and {1} is {2}", a, b, remainder);

}
catch(DivideByZeroException e) 
{
	Console.WriteLine(e);
}



