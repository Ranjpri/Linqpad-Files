<Query Kind="Statements" />

//See if a number is a prime number
Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
bool primeFlag = false;
if (n == 1)
{
	primeFlag = true;
}
for (int i = 2; i < n; i++)
{
	int remainder = n % i;
	if (remainder == 0)
	{
		primeFlag = true;
		break;
	}
}
if (primeFlag)
{
	Console.WriteLine("The number {0} is not prime", n);
}
else
{
	Console.WriteLine("The number {0} is prime", n);
}