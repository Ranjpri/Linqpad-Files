<Query Kind="Program" />

void Main()
{
	int[] arr = new int[] {4,6,7,8,3,4,8,0,1,10};
	int[] arr2 = MinMaxSwap(arr);
	arr2.Dump();
	
	
	
}

public int[] MinMaxSwap(int[] arr)
{
	int min = 0;
	int max = 0;
	for (int i = 1; i < arr.Length; i++)
	{
		if (arr[i] < arr[min])
		{
			min = i;
		}
		if (arr[i] > arr[max])
		{
			max = i;
		}
	}
	
	int temp = arr[min];
	arr[min] = arr[max];
	arr[max] = temp;
	return arr;
}

// Define other methods and classes here
