<Query Kind="Statements" />

String s1 = "spaps";
s1 = s1.ToUpper();

String reverseString = String.Empty;

for (int i = 0; i < s1.Length; i++)
{
	reverseString += s1[s1.Length - 1 - i];
}

if (reverseString.ToString() == s1.ToString())
{
	Console.WriteLine(s1 + " is a palindrome");
}
else
{
	Console.WriteLine(s1 + " is not a palindrome");
}