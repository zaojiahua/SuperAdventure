using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using System.Reflection;
using System.IO;
using Junfine.Debuger;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class GameManager : MonoBehaviour
{
	public LuaScriptMgr uluaMgr;

	void Awake ()
	{
		Init ();
	}

	void Init ()
	{
		DontDestroyOnLoad (gameObject);  //防止销毁自己
		uluaMgr = AppFacade.Instance.GetManager<LuaScriptMgr>(ManagerName.Lua);
		uluaMgr.Start();
	}

	void Start ()
	{
		uluaMgr.DoFile("GameLayer.lua");
	}
}
