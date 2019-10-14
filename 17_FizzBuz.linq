<Query Kind="Program" />

void Main()
{
	
	for (int i = 1; i <= 100; i++)
	{
		string value = String.Empty;
		if (i % 3 == 0)
		{
			value = "Fizz";
		}
		if (i % 5 == 0)
		{
			value += "Buzz";
		}
		if (value == String.Empty)
		{
			value = i.ToString();
		}
		Console.WriteLine(value);
	}
}

// Define other methods and classes here
