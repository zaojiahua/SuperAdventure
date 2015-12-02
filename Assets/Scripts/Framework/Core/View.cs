using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class View : MonoBehaviour, IView
{
	private AppFacade m_Facade;
	private LuaScriptMgr m_LuaMgr;

	public virtual void OnMessage (IMessage message)
	{
	}

	/// <summary>
	/// 注册消息
	/// </summary>
	/// <param name="view"></param>
	/// <param name="messages"></param>
	protected void RegisterMessage (IView view, List<string> messages)
	{
		if (messages == null || messages.Count == 0)
			return;
		Controller.Instance.RegisterViewCommand (view, messages.ToArray ());
	}

	/// <summary>
	/// 移除消息
	/// </summary>
	/// <param name="view"></param>
	/// <param name="messages"></param>
	protected void RemoveMessage (IView view, List<string> messages)
	{
		if (messages == null || messages.Count == 0)
			return;
		Controller.Instance.RemoveViewCommand (view, messages.ToArray ());
	}

	protected AppFacade facade {
		get {
			if (m_Facade == null) {
				m_Facade = AppFacade.Instance;
			}
			return m_Facade;
		}
	}

	protected LuaScriptMgr LuaManager {
		get {
			if (m_LuaMgr == null) {
				m_LuaMgr = facade.GetManager<LuaScriptMgr> (ManagerName.Lua);
			}
			return m_LuaMgr;
		}
		set { m_LuaMgr = value; }
	}
		
}
