using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace home_work
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Double a = 125.0;
			Double b = Math.Sqrt(a);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
