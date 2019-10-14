<Query Kind="Program" />

void Main()
{
	//Find GCD, LCM
	
	Console.WriteLine("Enter Number 1");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter Number 2");
	int num2 = Convert.ToInt32(Console.ReadLine());

	int gcd = GetGCD(num1, num2);
	gcd.Dump();
	int lcm = GetLCM(num1, num2);
	lcm.Dump();
	


}
public int GetGCD(int n1, int n2)
{

	while (n1 != n2)
	{
		if (n1 > n2)
		{
			n1 = n1- n2;
		}
		else if(n2 > n1) 
		{
			n2 = n2 - n1;
		}
		
	}
	return n1;
}
 public int GetLCM(int n1, int n2)
 {
 	int lcm = (n1*n2)/GetGCD(n1,n2);
	return lcm;
 }

// Define other methods and classes here
