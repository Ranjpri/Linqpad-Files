<Query Kind="Statements" />

String s = "malayala";
String reversedString = String.Empty;
for (int i = 0; i < s.Length; i++)
{
	reversedString += s[s.Length - 1 - i];
}
reversedString.Dump();