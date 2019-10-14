<Query Kind="Statements" />

//Check if a number and its reverse is a palindrome

Console.WriteLine("Enter a number");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = 0;
int remainder = 0;
int q = n1;

while (q != 0)
{
	remainder = q % 10;
	q = q / 10;
	n2 = n2 * 10 + remainder;

}
if (n2 == n1)
{
	Console.WriteLine("{0} is a palindromic number", n1);
}
else
{
	Console.WriteLine("{0} is not a palindromic number", n1);
}