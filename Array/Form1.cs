using System;

namespace Array
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Load += Form1_Load;	
		}
		private void Form1_Load(object sender, EventArgs e)
		{

			string[] names = { "Rhobbie", "Jhirro", "Raine", "Jolo", "Prince", "Mark" };

			listBox1.Items.Clear();
			listBox1.Items.AddRange(names);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string message = (textBox1.Text ?? string.Empty).ToLower();

			if (message.Contains("hello"))
			{
				label1.Text = "There it is - hello -";
			}
			else
			{
				label1.Text = "No - hello - ";
			}
			char[,] letters =
			{
				{ 'a', 'b', 'c' },
				{ 'd', 'e', 'f' }
			};
			string twoD = letters[0, 0] + " " + letters[0, 1] + " " + letters[0, 2] + "\n" +
					  letters[1, 0] + " " + letters[1, 1] + " " + letters[1, 2];
			MessageBox.Show(twoD, "2D Letters");
		}
	}
}
