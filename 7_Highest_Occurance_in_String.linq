<Query Kind="Statements" />

String actualString = "Monkeytttt Joes";
actualString = actualString.ToUpper();
char maxChar = actualString[0];
int count = 0;
for (int i = 0; i < actualString.Length; i++)
{
	int c = actualString.Count(s => s == actualString[i]);
	if (c >= count)
	{
		maxChar = actualString[i];
		count = c;
	}
}
Console.WriteLine("Most Frequent Character: "+maxChar);
