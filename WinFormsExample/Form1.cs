using System;
using System.Windows.Forms;
using BrainSharp;

namespace WinFormsExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			var interpreter = new Interpreter(Programs.HelloWorld)
			{
				OutputHandler = new OutputHandler(textBox1),
				InputHandler = new InputHandler()
			};
			interpreter.Interpret();
		}

	}

	public class InputHandler : IInputHandler
	{
		public char InputChar()
		{
			throw new NotImplementedException();
		}
	}

	public class OutputHandler : IOutputHandler
	{
		private TextBox textBox;

		public OutputHandler(TextBox textBox)
		{
			this.textBox = textBox;
		}

		public void OutputChar(char c)
		{
			textBox.Text += c;
		}

		public void RemoveChar()
		{
			throw new NotImplementedException();
		}
	}
}
