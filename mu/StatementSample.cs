using System;


class StatementSample
{ 
	static void Main()
	{
		double x, y, z;  //変数を宣言。
		
		// xにユーザーの入力した値を代入。
		Console.Write("input x : ");
		x = double.Parse(Console.ReadLine());
		
		// yにユーザーの入力した値を代入。
		Console.Write("input y : ");
		y = double.Parse(Console.ReadLine());
		
		//入力された値を元に計算
		z = x * x + y * y; //　ｚにｘとｙの二乗和を代入
		x /=  z;           //  ｘ = ｘ / z; と同じ。
		y /= -z;           //  ｙ = -y / z; と同じ。
		
		//計算結果を出力
		Console.Write("({0}, {1})", x, y);
		Console.ReadLine();
	}
}

