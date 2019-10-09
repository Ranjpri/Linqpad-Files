<Query Kind="Statements" />

// Print duplicate characters in string

String s = "hhgttekshdsatest";
String checkedStr = "";
String duplicateStr = String.Empty;
for (int i = 0; i < s.Length; i++)
{
	if (checkedStr.Length > 0)
	{
		if (checkedStr.Contains(s[i]))
		{
			if (!(duplicateStr.Contains(s[i])))
			{
				duplicateStr += s[i];
			}			
		}
		else
		{			
			checkedStr += s[i].ToString();					
		}
		
	}
	else
	{
		checkedStr = s[i].ToString();
	}
}
duplicateStr.Dump();
