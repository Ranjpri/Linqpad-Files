<Query Kind="Statements" />

String str = "asdfAsfaha";

String finalStr = String.Empty;
finalStr = str[0].ToString();
bool found = false;
for (int i = 1; i < str.Length; i++)
{
	found = finalStr.ToUpper().Contains(str[i].ToString().ToUpper());
	if (!found)
	{
		finalStr +=str[i];
	}
}
finalStr.Dump();