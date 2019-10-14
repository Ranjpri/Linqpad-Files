<Query Kind="Statements" />

//Factors of a number
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
List<int> factorials = new List<int>();
for (int i = 1; i <= n; i++)
{
	if (n % i == 0)
	{
		factorials.Add(i);
	}
}
Console.WriteLine(factorials);