using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LuaBehavioursWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateLuaBehaviours),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("luaModule", get_luaModule, set_luaModule),
			new LuaField("onStart", get_onStart, set_onStart),
			new LuaField("onUpdate", get_onUpdate, set_onUpdate),
			new LuaField("onLateUpdate", get_onLateUpdate, set_onLateUpdate),
			new LuaField("onFixedUpdate", get_onFixedUpdate, set_onFixedUpdate),
			new LuaField("onOnApplicationFocus", get_onOnApplicationFocus, set_onOnApplicationFocus),
			new LuaField("onOnApplicationPause", get_onOnApplicationPause, set_onOnApplicationPause),
			new LuaField("onOnApplicationQuit", get_onOnApplicationQuit, set_onOnApplicationQuit),
			new LuaField("onOnCollisionEnter", get_onOnCollisionEnter, set_onOnCollisionEnter),
			new LuaField("onOnCollisionEnter2D", get_onOnCollisionEnter2D, set_onOnCollisionEnter2D),
			new LuaField("onOnCollisionExit", get_onOnCollisionExit, set_onOnCollisionExit),
			new LuaField("onOnCollisionExit2D", get_onOnCollisionExit2D, set_onOnCollisionExit2D),
			new LuaField("onOnCollisionStay", get_onOnCollisionStay, set_onOnCollisionStay),
			new LuaField("onOnCollisionStay2D", get_onOnCollisionStay2D, set_onOnCollisionStay2D),
			new LuaField("onOnDestroy", get_onOnDestroy, set_onOnDestroy),
			new LuaField("onOnDisable", get_onOnDisable, set_onOnDisable),
			new LuaField("onOnDrawGizmos", get_onOnDrawGizmos, set_onOnDrawGizmos),
			new LuaField("onOnDrawGizmosSelected", get_onOnDrawGizmosSelected, set_onOnDrawGizmosSelected),
			new LuaField("onOnEnable", get_onOnEnable, set_onOnEnable),
			new LuaField("onOnGUI", get_onOnGUI, set_onOnGUI),
			new LuaField("onOnLevelWasLoaded", get_onOnLevelWasLoaded, set_onOnLevelWasLoaded),
			new LuaField("onOnMouseDown", get_onOnMouseDown, set_onOnMouseDown),
			new LuaField("onOnMouseDrag", get_onOnMouseDrag, set_onOnMouseDrag),
			new LuaField("onOnMouseEnter", get_onOnMouseEnter, set_onOnMouseEnter),
			new LuaField("onOnMouseExit", get_onOnMouseExit, set_onOnMouseExit),
			new LuaField("onOnMouseOver", get_onOnMouseOver, set_onOnMouseOver),
			new LuaField("onOnMouseUp", get_onOnMouseUp, set_onOnMouseUp),
			new LuaField("onOnMouseUpAsButton", get_onOnMouseUpAsButton, set_onOnMouseUpAsButton),
			new LuaField("onOnParticleCollision", get_onOnParticleCollision, set_onOnParticleCollision),
			new LuaField("onOnTriggerEnter", get_onOnTriggerEnter, set_onOnTriggerEnter),
			new LuaField("onOnTriggerEnter2D", get_onOnTriggerEnter2D, set_onOnTriggerEnter2D),
			new LuaField("onOnTriggerExit", get_onOnTriggerExit, set_onOnTriggerExit),
			new LuaField("onOnTriggerExit2D", get_onOnTriggerExit2D, set_onOnTriggerExit2D),
			new LuaField("onOnTriggerStay", get_onOnTriggerStay, set_onOnTriggerStay),
			new LuaField("onOnTriggerStay2D", get_onOnTriggerStay2D, set_onOnTriggerStay2D),
			new LuaField("onReset", get_onReset, set_onReset),
			new LuaField("onOnAnimatorMove", get_onOnAnimatorMove, set_onOnAnimatorMove),
			new LuaField("onOnAnimatorIK", get_onOnAnimatorIK, set_onOnAnimatorIK),
		};

		LuaScriptMgr.RegisterLib(L, "LuaBehaviours", typeof(LuaBehaviours), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaBehaviours(IntPtr L)
	{
		LuaDLL.luaL_error(L, "LuaBehaviours class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(LuaBehaviours);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaModule(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name luaModule");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index luaModule on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.luaModule);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onStart(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onStart");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onStart on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onStart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onUpdate on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onUpdate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onLateUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onLateUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onLateUpdate on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onLateUpdate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onFixedUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onFixedUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onFixedUpdate on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onFixedUpdate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnApplicationFocus(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationFocus");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationFocus on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnApplicationFocus);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnApplicationPause(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationPause");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationPause on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnApplicationPause);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnApplicationQuit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationQuit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationQuit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnApplicationQuit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionEnter on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionEnter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionEnter2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionEnter2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionEnter2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionEnter2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionExit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionExit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionExit2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionExit2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionExit2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionExit2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionStay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionStay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionStay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionStay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnCollisionStay2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionStay2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionStay2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnCollisionStay2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnDestroy(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDestroy");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDestroy on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnDestroy);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnDisable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDisable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDisable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnDisable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnDrawGizmos(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDrawGizmos");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDrawGizmos on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnDrawGizmos);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnDrawGizmosSelected(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDrawGizmosSelected");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDrawGizmosSelected on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnDrawGizmosSelected);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnEnable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnEnable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnEnable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnEnable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnGUI(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnGUI");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnGUI on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnGUI);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnLevelWasLoaded(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnLevelWasLoaded");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnLevelWasLoaded on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnLevelWasLoaded);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseDown(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseDown");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseDown on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseDrag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseDrag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseEnter on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseEnter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseExit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseExit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseOver(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseOver");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseOver on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseOver);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseUp(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseUp");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseUp on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseUp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnMouseUpAsButton(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseUpAsButton");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseUpAsButton on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnMouseUpAsButton);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnParticleCollision(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnParticleCollision");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnParticleCollision on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnParticleCollision);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerEnter on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerEnter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerEnter2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerEnter2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerEnter2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerEnter2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerExit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerExit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerExit2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerExit2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerExit2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerExit2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerStay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerStay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerStay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerStay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnTriggerStay2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerStay2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerStay2D on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnTriggerStay2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onReset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onReset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnAnimatorMove(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnAnimatorMove");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnAnimatorMove on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnAnimatorMove);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onOnAnimatorIK(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnAnimatorIK");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnAnimatorIK on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onOnAnimatorIK);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaModule(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name luaModule");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index luaModule on a nil value");
			}
		}

		obj.luaModule = LuaScriptMgr.GetLuaTable(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onStart(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onStart");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onStart on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onStart = (LuaBehaviours.LuaMethord)LuaScriptMgr.GetNetObject(L, 3, typeof(LuaBehaviours.LuaMethord));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onStart = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onUpdate on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onUpdate = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onUpdate = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onLateUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onLateUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onLateUpdate on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onLateUpdate = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onLateUpdate = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onFixedUpdate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onFixedUpdate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onFixedUpdate on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onFixedUpdate = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onFixedUpdate = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnApplicationFocus(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationFocus");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationFocus on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnApplicationFocus = (Action<bool>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<bool>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnApplicationFocus = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnApplicationPause(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationPause");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationPause on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnApplicationPause = (Action<bool>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<bool>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnApplicationPause = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnApplicationQuit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnApplicationQuit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnApplicationQuit on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnApplicationQuit = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnApplicationQuit = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionEnter on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionEnter = (Action<Collision>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionEnter = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionEnter2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionEnter2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionEnter2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionEnter2D = (Action<Collision2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionEnter2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionExit on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionExit = (Action<Collision>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionExit = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionExit2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionExit2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionExit2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionExit2D = (Action<Collision2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionExit2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionStay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionStay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionStay on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionStay = (Action<Collision>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionStay = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnCollisionStay2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnCollisionStay2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnCollisionStay2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnCollisionStay2D = (Action<Collision2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collision2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnCollisionStay2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnDestroy(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDestroy");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDestroy on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnDestroy = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnDestroy = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnDisable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDisable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDisable on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnDisable = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnDisable = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnDrawGizmos(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDrawGizmos");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDrawGizmos on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnDrawGizmos = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnDrawGizmos = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnDrawGizmosSelected(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnDrawGizmosSelected");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnDrawGizmosSelected on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnDrawGizmosSelected = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnDrawGizmosSelected = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnEnable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnEnable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnEnable on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnEnable = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnEnable = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnGUI(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnGUI");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnGUI on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnGUI = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnGUI = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnLevelWasLoaded(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnLevelWasLoaded");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnLevelWasLoaded on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnLevelWasLoaded = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnLevelWasLoaded = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseDown(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseDown");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseDown on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseDown = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseDown = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseDrag on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseDrag = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseDrag = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseEnter on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseEnter = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseEnter = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseExit on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseExit = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseExit = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseOver(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseOver");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseOver on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseOver = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseOver = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseUp(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseUp");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseUp on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseUp = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseUp = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnMouseUpAsButton(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnMouseUpAsButton");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnMouseUpAsButton on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnMouseUpAsButton = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnMouseUpAsButton = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnParticleCollision(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnParticleCollision");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnParticleCollision on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnParticleCollision = (Action<GameObject>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<GameObject>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnParticleCollision = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerEnter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerEnter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerEnter on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerEnter = (Action<Collider>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerEnter = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerEnter2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerEnter2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerEnter2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerEnter2D = (Action<Collider2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerEnter2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerExit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerExit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerExit on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerExit = (Action<Collider>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerExit = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerExit2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerExit2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerExit2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerExit2D = (Action<Collider2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerExit2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerStay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerStay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerStay on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerStay = (Action<Collider>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerStay = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnTriggerStay2D(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnTriggerStay2D");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnTriggerStay2D on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnTriggerStay2D = (Action<Collider2D>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<Collider2D>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnTriggerStay2D = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onReset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReset on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onReset = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onReset = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnAnimatorMove(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnAnimatorMove");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnAnimatorMove on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnAnimatorMove = (Action)LuaScriptMgr.GetNetObject(L, 3, typeof(Action));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnAnimatorMove = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onOnAnimatorIK(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaBehaviours obj = (LuaBehaviours)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onOnAnimatorIK");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onOnAnimatorIK on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.onOnAnimatorIK = (Action<int>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<int>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.onOnAnimatorIK = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

