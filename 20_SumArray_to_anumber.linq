<Query Kind="Program" />

void Main()
{
	//Determine if any two integers in array sum to given integer
	int[] arr = new int[10];
	Console.WriteLine("Enter 10 elements of an array");
	for (int i = 0; i < 10; i++)
	{
		arr[i] = Convert.ToInt32(Console.ReadLine());
	}

	Console.WriteLine("Enter the number you are looking for?");
  	int x = Convert.ToInt32(Console.ReadLine());
	for (int i = 0; i < 10; i++)
	{
		for (int j = i; j < 10; j++)
		{
			if (i != j)
			{
				if (arr[i] + arr[j] == x)
				{
					Console.WriteLine("{0} + {1} = {2} found", arr[i], arr[j], x);
					break;
				}
			}			
		}
	}
	
}

// Define other methods and classes here
