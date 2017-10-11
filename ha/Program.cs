using System;
using System.Windows;
using System.Windows.Controls;


public class fast
{
	[STAThread]
	static void Main()
	{
		var button = new Button {Content = "ここを押せ"};
		button.Click +=(sender, e) => MessageBox.Show("ようこそ");
		
		var Win = new Window
			
		{
			Title = "サンプルプログラム",
			Width = 300,
			Height = 200,
			Content =  button
		};
		
		var app = new Application();
		app.Run(Win);
	}
}