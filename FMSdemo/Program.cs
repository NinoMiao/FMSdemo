/*
 * 由SharpDevelop创建。
 * 用户：熊梓杉
 * 日期: 2018-8-6
 * 时间: 20:28
 */
using System;
using System.Windows.Forms;

namespace FMSdemo
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
			Application.Run(new MainForm());
		}
		
	}
}
