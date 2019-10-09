<Query Kind="Statements" />

String sentence = "I am living  here";
String sen = sentence.Trim().Replace("  ", " ");
sen.Dump();
int countNumOfSpaces = sen.Count(s => s == ' ' );
Console.WriteLine("Number of words is:"+ (countNumOfSpaces+1));