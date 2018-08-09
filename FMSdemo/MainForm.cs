/*
 * 由SharpDevelop创建。
 * 用户：熊梓杉
 * 日期: 2018-8-6
 * 时间: 20:28
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
 
namespace FMSdemo
{
	
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static TextBox debug=new TextBox();
		public MainForm()
		{
			 
		   
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
	
			Clair=new Hero();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
//		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
//		{
//			if()
//			return base.ProcessCmdKey(ref msg, keyData);
//		}
		public Hero Clair;
		public 	void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Up:
					Clair.Act(ActStyle.UP);
					debug.AppendText("__↑__");
					break;
				case Keys.Down:
					Clair.Act(ActStyle.DOWN);
					debug.AppendText("__↓__");
					break;
//				case Keys.Left:
//					
//					Clair.Act(ActStyle.LEFT);
//					break;
//				case Keys.Right:
//					Clair.Act(ActStyle.RIGHT);
//					break;
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			textbox1.Text=debug.Text;
			
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			Clair.Update();
	
		}
		 
		
		
		
		
	}

}
