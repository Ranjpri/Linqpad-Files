<Query Kind="Program" />

void Main()
{
	int[] arr = new int[] { 4, 6, 6, 6, 3, 6, 6, 0, 1, 6 };
	//Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
	
	int majorityNumber = arr.Length / 2 ;
	int value = 0;
	int count = 0;
	Dictionary<int, int> x = new Dictionary<int, int>();
	for (int i = 0; i < arr.Length; i++)
	{
		count =0;
		count = (Array.FindAll(arr, s => s == arr[i])).Count();
		if (count >= majorityNumber)
		{
			value = arr[i];
			break;
		}
		
	}
	if (count > majorityNumber)
	{
		value.Dump();
	}
	else
	{
		Console.WriteLine("No majority number");	
	}
	
}

// Define other methods and classes here
