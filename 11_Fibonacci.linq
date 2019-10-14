<Query Kind="Statements" />

//Find the nth number of fibonacci series
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
List<int> l = new List<int>();
l.Add(0);
l.Add(1);
l.Add(sum);
if (n > 2)
{
	for (int i = 3; i < n; i++)
	{
		sum = l[i-2]+l[i-1];
		l.Add(sum);
	}
}

Console.WriteLine("Fibonacci series at {0} is {1}", n, l[n-1]);