using System;

class third
{
	static void Main()
	{
//		var str =Console.ReadLine();
//		
//		var y			= int.Parse(Console.ReadLine());
//		var x = double.Parse(Console.ReadLine());
		
//		int m = 1, n = 3;
//		Console.Write("m = {0}, n = {1}", m, n);
		
		Console.Write("あなたのお名前は？ : ");
		var name = Console.ReadLine();
		
		Console.Write("あなたのお年は？　 : ");
		var age = int.Parse(Console.ReadLine());
		
		Console.WriteLine("{0}({1}歳)さん、ようこそお越しくださいました。", name, age);
		Console.ReadLine();
	}
}

