<Query Kind="Statements" />

String str = "hgty";
for (int j = 1; j <= str.Length; j++)
{
//	j.Dump();
	for (int i = 0; i < str.Length - j + 1; i++)
	{
		Console.WriteLine(str.Substring(i, j));
	}
}