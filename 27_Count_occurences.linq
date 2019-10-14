<Query Kind="Program" />

void Main()
{
	//Count occurences using Dictionary
	
	int[] arr = new int[] {4,6,7,8,3,4,8,0,1,10,8};
	Dictionary<int, int> dict = new Dictionary<int, int>();
	int value = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (dict.ContainsKey(arr[i]))
		{
			value = dict[arr[i]];
			dict[arr[i]] = ++value;
		}
		else
		{
			dict[arr[i]] = 1;
		}
	}
	
	dict.Dump();
	
}

// Define other methods and classes here
