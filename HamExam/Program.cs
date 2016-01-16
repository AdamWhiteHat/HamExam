/*
 * Created by SharpDevelop.
 * User: BurningBunny
 * Date: 1/14/2013
 * Time: 2:51 PM
 * 
 * 
 */
using System;
using System.Windows.Forms;
using System.Threading;

namespace HamExam
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += new ThreadExceptionEventHandler(MainForm.MyExceptionHandler);
			Application.Run(new MainForm());
		}
		
	}
}
