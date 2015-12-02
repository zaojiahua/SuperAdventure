using UnityEngine;
using System.Collections;
using System;
using LuaInterface;

public class LuaBehaviours : MonoBehaviour
{
	public LuaTable luaModule;

	public delegate void LuaMethord(LuaTable t);

	public LuaMethord onStart;

	void Start ()
	{
		if (onStart != null)
			onStart (luaModule);
	}

	public LuaMethord onUpdate;

	void Update ()
	{
		if (onUpdate != null)
			onUpdate (luaModule);
	}

	public LuaMethord onLateUpdate;

	void LateUpdate ()
	{
		if (onLateUpdate != null)
			onLateUpdate (luaModule);
	}

	public LuaMethord onFixedUpdate;

	void FixedUpdate ()
	{
		if (onFixedUpdate != null)
			onFixedUpdate (luaModule);
	}

	public delegate void LuaMethordBool(LuaTable t,bool b);

	public LuaMethordBool onOnApplicationFocus;

	void OnApplicationFocus (bool focusStatus)
	{
		if (onOnApplicationFocus != null)
			onOnApplicationFocus (luaModule,focusStatus);
	}

	public LuaMethordBool onOnApplicationPause;

	void OnApplicationPause (bool pauseStatus)
	{
		if (onOnApplicationPause != null)
			onOnApplicationPause (luaModule,pauseStatus);
	}

	public LuaMethord onOnApplicationQuit;

	void OnApplicationQuit ()
	{
		if (onOnApplicationQuit != null)
			onOnApplicationQuit (luaModule);
	}

	public delegate void LuaMethordCollision(LuaTable t,Collision b);

	public LuaMethordCollision onOnCollisionEnter;

	void OnCollisionEnter (Collision collision)
	{
		if (onOnCollisionEnter != null)
			onOnCollisionEnter (luaModule, collision);
	}

	public delegate void LuaMethordCollision2D(LuaTable t,Collision2D b);

	public LuaMethordCollision2D onOnCollisionEnter2D;

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (onOnCollisionEnter2D != null)
			onOnCollisionEnter2D (luaModule, coll);
	}

	public LuaMethordCollision onOnCollisionExit;

	void OnCollisionExit (Collision collision)
	{
		if (onOnCollisionExit != null)
			onOnCollisionExit (luaModule, collision);
	}

	public LuaMethordCollision2D onOnCollisionExit2D;

	void OnCollisionExit2D (Collision2D coll)
	{
		if (onOnCollisionExit2D != null)
			onOnCollisionExit2D (luaModule, coll);
	}

	public LuaMethordCollision onOnCollisionStay;

	void OnCollisionStay (Collision collisionInfo)
	{
		if (onOnCollisionStay != null)
			onOnCollisionStay (luaModule, collisionInfo);
	}

	public LuaMethordCollision2D onOnCollisionStay2D;

	void OnCollisionStay2D (Collision2D coll)
	{
		if (onOnCollisionStay2D != null)
			onOnCollisionStay2D (luaModule, coll);
	}

	public LuaMethord onOnDestroy;

	void OnDestroy ()
	{
		if (onOnDestroy != null)
			onOnDestroy (luaModule);
	}

	public LuaMethord onOnDisable;

	void OnDisable ()
	{
		if (onOnDisable != null)
			onOnDisable (luaModule);
	}

	public LuaMethord onOnDrawGizmos;

	void OnDrawGizmos ()
	{
		if (onOnDrawGizmos != null)
			onOnDrawGizmos (luaModule);
	}

	public LuaMethord onOnDrawGizmosSelected;

	void OnDrawGizmosSelected ()
	{
		if (onOnDrawGizmosSelected != null)
			onOnDrawGizmosSelected (luaModule);
	}

	public LuaMethord onOnEnable;

	void OnEnable ()
	{
		if (onOnEnable != null)
			onOnEnable (luaModule);
	}

	public LuaMethord onOnGUI;

	void OnGUI ()
	{
		if (onOnGUI != null)
			onOnGUI (luaModule);
	}

	public LuaMethord onOnLevelWasLoaded;

	void OnLevelWasLoaded ()
	{
		if (onOnLevelWasLoaded != null)
			onOnLevelWasLoaded (luaModule);
	}

	public LuaMethord onOnMouseDown;

	void OnMouseDown ()
	{
		if (onOnMouseDown != null)
			onOnMouseDown (luaModule);
	}

	public LuaMethord onOnMouseDrag;

	void OnMouseDrag ()
	{
		if (onOnMouseDrag != null)
			onOnMouseDrag (luaModule);
	}

	public LuaMethord onOnMouseEnter;

	void OnMouseEnter ()
	{
		if (onOnMouseEnter != null)
			onOnMouseEnter (luaModule);
	}

	public LuaMethord onOnMouseExit;

	void OnMouseExit ()
	{
		if (onOnMouseExit != null)
			onOnMouseExit (luaModule);
	}

	public LuaMethord onOnMouseOver;

	void OnMouseOver ()
	{
		if (onOnMouseOver != null)
			onOnMouseOver (luaModule);
	}

	public LuaMethord onOnMouseUp;

	void OnMouseUp ()
	{
		if (onOnMouseUp != null)
			onOnMouseUp (luaModule);
	}

	public LuaMethord onOnMouseUpAsButton;

	void OnMouseUpAsButton ()
	{
		if (onOnMouseUpAsButton != null)
			onOnMouseUpAsButton (luaModule);
	}

	public delegate void LuaMethordGameObject(LuaTable t,GameObject b);

	public LuaMethordGameObject onOnParticleCollision;

	void OnParticleCollision (GameObject other)
	{
		if (onOnParticleCollision != null)
			onOnParticleCollision (luaModule, other);
	}

	public delegate void LuaMethordCollider(LuaTable T, Collider c);

	public LuaMethordCollider onOnTriggerEnter;

	void OnTriggerEnter (Collider other)
	{
		if (onOnTriggerEnter != null)
			onOnTriggerEnter (luaModule, other);
	}

	public delegate void LuaMethordCollider2D(LuaTable T, Collider2D c);

	public LuaMethordCollider2D onOnTriggerEnter2D;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (onOnTriggerEnter2D != null)
			onOnTriggerEnter2D (luaModule, other);
	}

	public LuaMethordCollider onOnTriggerExit;

	void OnTriggerExit (Collider other)
	{
		if (onOnTriggerExit != null)
			onOnTriggerExit (luaModule, other);
	}

	public LuaMethordCollider2D onOnTriggerExit2D;

	void OnTriggerExit2D (Collider2D other)
	{
		if (onOnTriggerExit2D != null)
			onOnTriggerExit2D (luaModule,other);
	}

	public LuaMethordCollider onOnTriggerStay;

	void OnTriggerStay (Collider other)
	{
		if (onOnTriggerStay != null)
			onOnTriggerStay (luaModule, other);
	}

	public LuaMethordCollider2D onOnTriggerStay2D;

	void OnTriggerStay2D (Collider2D other)
	{
		if (onOnTriggerStay2D != null)
			onOnTriggerStay2D (luaModule,other);
	}
}
