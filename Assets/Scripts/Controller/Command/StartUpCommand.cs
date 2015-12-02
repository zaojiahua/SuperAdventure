using UnityEngine;
using System.Collections;
using SimpleFramework;

public class StartUpCommand : ControllerCommand
{

	public override void Execute (IMessage message)
	{
		if (!Util.CheckEnvironment ())
			return;

		//-----------------初始化管理器-----------------------
		AppFacade.Instance.AddManager (ManagerName.Lua, new LuaScriptMgr ());
		AppFacade.Instance.AddManager<GameManager>(ManagerName.Game);

		Debug.Log ("StartUp-------->>>>>");
	}
}