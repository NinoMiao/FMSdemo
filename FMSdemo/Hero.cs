/*
 * 由SharpDevelop创建。
 * 用户：熊梓杉
 * 日期: 2018-8-7
 * 时间: 9:30
 */
using System;
using System.Threading;

namespace FMSdemo
{
	
	
	public enum ActStyle
	{
		UP,
		DOWN,
		LEFT,
		RIGHT
	}
//	public enum RoleState
//	{
//		STAND_UP,
//		CROUCH,
//		KILL,
//		JUMP
//	}
	
	/// <summary>
	/// Description of Hero.
	/// </summary>
	public class Hero
	{
//		private StateMachine m_stateMachine;
//		RoleState curState;
		IState CurState;
		 
		 
		public Hero()
		{
			MainForm.debug.AppendText("创建一个英雄，初始状态为站着      ");
			CurState=new State_StandUp();
//			ChangeState();
			 
		}
		public  void Update()
		{
		    CurState.Execute(this);
				
		}
		public void Act(ActStyle act)
		{
			CurState.ReceiveInput(this,act);
		}
		public void ChangeState(IState state)
		{
			CurState=null;
			CurState=state;
			
//			MainForm.debug.AppendText(CurState.ToString()+"--------");
			
			
//			switch(state)
//			{
//				case RoleState.CROUCH:
//					StateMachine=new Crouch();
//					break;
//				case RoleState.JUMP:
//					StateMachine=new Jump();
//					break;
//				case RoleState.KILL:
//					StateMachine=new Kill();
//					break;
//				case RoleState.STAND_UP:
//					StateMachine=new State_StandUp();
//					break;
//			}
		}
	}
	public class State_StandUp:IState
	{
		public  void ReceiveInput(Hero role,ActStyle act)
		{
			switch(act)
			{
				case ActStyle.DOWN:
					role.ChangeState(new Crouch());
					break;
				case ActStyle.UP:
					role.ChangeState(new Jump());
					break;
			}
			
		}
		public void Execute(Hero role)
		{
			MainForm.debug.AppendText("站着     ");
		}
		public override string ToString()
		{
			return base.ToString();
		}
		
	}
	public class Crouch:IState
	{
		public void ReceiveInput(Hero role,ActStyle act)
		{
			switch(act)
			{
				case ActStyle.UP:
					role.ChangeState(new State_StandUp());
					break;
			}
		}
		public void Execute(Hero role)
		{
			MainForm.debug.AppendText("下蹲    ");
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
	public class Kill:IState
	{
		public void ReceiveInput(Hero role,ActStyle act)
		{
			 
		}
		public void Execute(Hero role)
		{
			MainForm.debug.AppendText("攻击    ");
			role.ChangeState(new State_StandUp());
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
	public class Jump:IState
	{
		public void ReceiveInput(Hero role,ActStyle act)
		{
			if (act==ActStyle.DOWN)
			{
				role.ChangeState(new Kill());
			}
		}
		int time=0;
		public void Execute(Hero role)
		{ 
			time++;
				MainForm.debug.AppendText("跳跃中"+time.ToString()+"   ");
				if(time>4)
				{
					role.ChangeState(new State_StandUp());
				}
		}
		 
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
