<Query Kind="Statements" />

String s1 = "sparps";
String s2 = "raspa";
bool chkFlagAnagram = true;

if (s1.Length == s2.Length)
{
	for (int i = 0; i < s1.Length; i++)
	{
		char charInLocnS1 = s1[i];
		int countInS1 = s1.Where(s=>s == charInLocnS1).Count();
		int countInS2 = s2.Count(s => s == charInLocnS1);
		if (countInS1 != countInS2)
		{
			chkFlagAnagram = false;
		}
		
	}
}
else
{
	chkFlagAnagram = false;
}
if (chkFlagAnagram)
{
	Console.WriteLine("{0} & {1} are Anagrams", s1, s2);
}
else
{
	Console.WriteLine("{0} & {1} are not Anagrams", s1, s2);
}