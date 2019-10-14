<Query Kind="Program" />

void Main()
{
	//Sort in Descending Order
	int[] arr = new int[10];
	Console.WriteLine("Enter 10 elements of an array");
	for (int i = 0; i < 10; i++)
	{
		arr[i] = Convert.ToInt32(Console.ReadLine());
	}
    int temp = arr[0];
	for (int i = 0; i < 10; i++)
	{
		for (int j = i+1; j < 10; j++)
		{
			if (arr[i] < arr[j])
			{
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				
			}
		}
	}
	arr[0].Dump();
	arr.Dump();
}


// Define other methods and classes here
