<Query Kind="Program" />

void Main()
{
	//Check if a number is an Armstrong number or not
	//An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself.

	Console.WriteLine("Enter a number");
	int digit100 = 1;
	int digit10 =1;
	int digitOnes=1;
	int sumOfCubesOfDigits = 1;

	int number = Convert.ToInt32(Console.ReadLine());
	
	if ((number <= 99) || (number > 999))
	{
		sumOfCubesOfDigits = 1;
		
	}
	else
	{
		digit100 = number /100;
		digit10 = (number-digit100*100)/10;
		digitOnes = number%10;
		sumOfCubesOfDigits = (digit100*digit100*digit100) + (digit10*digit10*digit10) + (digitOnes*digitOnes*digitOnes);

	}
	if (sumOfCubesOfDigits == number)
	{
		Console.WriteLine("{0} is a Armstrong Number", number);
	}
	else
	{
		Console.WriteLine("{0} is not a Armstrong Number", number);
	}
}

// Define other methods and classes here
