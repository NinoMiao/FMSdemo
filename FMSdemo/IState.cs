/*
 * 由SharpDevelop创建。
 * 用户：熊梓杉
 * 日期: 2018-8-6
 * 时间: 20:55
 */
using System;

namespace FMSdemo
{
	/// <summary>
	/// Description of IState.
	/// </summary>
	public interface IState
	{
		void ReceiveInput(Hero role,ActStyle act);
		void Execute(Hero role);
	}
}
