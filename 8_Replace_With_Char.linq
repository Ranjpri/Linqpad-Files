<Query Kind="Statements" />

//Replace all spaces with %20

String str = "this is a good day";
char c = ' ';
String newStr = str.Replace(" ","%20" );
newStr.Dump();