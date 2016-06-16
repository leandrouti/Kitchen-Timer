using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sound
{
	public partial class Timer : Form
	{
		private int time;
		public Timer()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = time.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(timer1.Enabled == false)
			{
				timer1.Enabled = true;
				button1.Text = "Stop";
			}else
			{
				timer1.Enabled = false;
				button1.Text = "Start";
				
			}
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			if(time <= 0)
			{
				SoundPlayer snd = new SoundPlayer(@"c:\windows\media\Alarm01.wav");
				snd.Play();
				timer1.Enabled = false;
				button1.Text = "Start";
				MessageBox.Show("Time up!");
				time = Int32.Parse(textBox1.Text);
				label1.Text = textBox1.Text;
					
			}else
			{
				time--;
				 
			}
			label1.Text = time.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{

			int result;

			if (Int32.TryParse(textBox1.Text, out result)) { 
				time = result;
				label1.Text = result.ToString();
			}else
			{
				MessageBox.Show("Only numbers are allowed");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			textBox1.Text = 1800.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = 600.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = 18.ToString();
		}
	}
}
