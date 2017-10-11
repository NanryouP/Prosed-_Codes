using System;
using System.Windows.Forms;
using System.Drawing;
	
class WelcomeForm : Form
{
	Button button;
		
	WelcomeForm()
	{
		this.Text = "サンプルプログラム";
		this.ClientSize = new Size(256, 64);
			
		this.button = new Button();
		this.button.Location = new Point(80, 16);
		this.button.Size = new Size(96, 32);
		this.button.Text = "ここを押せ";
		this.button.Click += new EventHandler(button_Click);
		this.Controls.Add(this.button);	
	}
		
	private void button_Click(object sender, System.EventArgs e)
	{
		MessageBox.Show("ようこそ。");
	}
		
	static void Main()
	{
		Application.Run(new WelcomeForm());
	}
}
