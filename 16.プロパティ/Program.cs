using System;

class Class1
{
	public string name1 { get; set; }
	public string name2 { get;} = "あ";
}
class Test1
{
	static void Main()
	{
		var c1 = new Class1();
		var c2 = new Class1();
		var c3 = new Class1();

		c1.name1 = "い";
		c2.name1 = "う";

		Console.WriteLine(c1.name1);
		Console.WriteLine(c2.name1);
		Console.WriteLine(c3.name2);
	}
}