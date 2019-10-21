using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			// Create a Random object called randomizer
			// to generate random numbers.
			Random randomizer = new Random();

			// These integer variables store the numbers
			// for the addition problem.
			int addend1 = randomizer.Next(51);
			int addend2 = randomizer.Next(51);

			// Convert the two randomly generated numbers
			// into strings so that they can be displayed
			// in the label controls.
			plusLeftLabel.Text = addend1.ToString();
			plusRightLabel.Text = addend2.ToString();

			// 'sum' is the name of the NumericUpDown control.
			// This step makes sure its value is zero before
			// adding any valuse to it.
			sum.Value = 0;

			InitializeComponent();
		}
	}
}
