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

	public Action onUpdate;

	void Update ()
	{
		if (onUpdate != null)
			onUpdate ();
	}

	public Action onLateUpdate;

	void LateUpdate ()
	{
		if (onLateUpdate != null)
			onLateUpdate ();
	}

	public Action onFixedUpdate;

	void FixedUpdate ()
	{
		if (onFixedUpdate != null)
			onFixedUpdate ();
	}

	public Action<bool> onOnApplicationFocus;

	void OnApplicationFocus (bool focusStatus)
	{
		if (onOnApplicationFocus != null)
			onOnApplicationFocus (focusStatus);
	}

	public Action<bool> onOnApplicationPause;

	void OnApplicationPause (bool pauseStatus)
	{
		if (onOnApplicationPause != null)
			onOnApplicationPause (pauseStatus);
	}

	public Action onOnApplicationQuit;

	void OnApplicationQuit ()
	{
		if (onOnApplicationQuit != null)
			onOnApplicationQuit ();
	}

	public Action<Collision> onOnCollisionEnter;

	void OnCollisionEnter (Collision collision)
	{
		if (onOnCollisionEnter != null)
			onOnCollisionEnter (collision);
	}

	public Action<Collision2D> onOnCollisionEnter2D;

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (onOnCollisionEnter2D != null)
			onOnCollisionEnter2D (coll);
	}

	public Action<Collision> onOnCollisionExit;

	void OnCollisionExit (Collision collision)
	{
		if (onOnCollisionExit != null)
			onOnCollisionExit (collision);
	}

	public Action<Collision2D> onOnCollisionExit2D;

	void OnCollisionExit2D (Collision2D coll)
	{
		if (onOnCollisionExit2D != null)
			onOnCollisionExit2D (coll);
	}

	public Action<Collision> onOnCollisionStay;

	void OnCollisionStay (Collision collisionInfo)
	{
		if (onOnCollisionStay != null)
			onOnCollisionStay (collisionInfo);
	}

	public Action<Collision2D> onOnCollisionStay2D;

	void OnCollisionStay2D (Collision2D coll)
	{
		if (onOnCollisionStay2D != null)
			onOnCollisionStay2D (coll);
	}

	public Action onOnDestroy;

	void OnDestroy ()
	{
		if (onOnDestroy != null)
			onOnDestroy ();
	}

	public Action onOnDisable;

	void OnDisable ()
	{
		if (onOnDisable != null)
			onOnDisable ();
	}

	public Action onOnDrawGizmos;

	void OnDrawGizmos ()
	{
		if (onOnDrawGizmos != null)
			onOnDrawGizmos ();
	}

	public Action onOnDrawGizmosSelected;

	void OnDrawGizmosSelected ()
	{
		if (onOnDrawGizmosSelected != null)
			onOnDrawGizmosSelected ();
	}

	public Action onOnEnable;

	void OnEnable ()
	{
		if (onOnEnable != null)
			onOnEnable ();
	}

	public Action onOnGUI;

	void OnGUI ()
	{
		if (onOnGUI != null)
			onOnGUI ();
	}

	public Action onOnLevelWasLoaded;

	void OnLevelWasLoaded ()
	{
		if (onOnLevelWasLoaded != null)
			onOnLevelWasLoaded ();
	}

	public Action onOnMouseDown;

	void OnMouseDown ()
	{
		if (onOnMouseDown != null)
			onOnMouseDown ();
	}

	public Action onOnMouseDrag;

	void OnMouseDrag ()
	{
		if (onOnMouseDrag != null)
			onOnMouseDrag ();
	}

	public Action onOnMouseEnter;

	void OnMouseEnter ()
	{
		if (onOnMouseEnter != null)
			onOnMouseEnter ();
	}

	public Action onOnMouseExit;

	void OnMouseExit ()
	{
		if (onOnMouseExit != null)
			onOnMouseExit ();
	}

	public Action onOnMouseOver;

	void OnMouseOver ()
	{
		if (onOnMouseOver != null)
			onOnMouseOver ();
	}

	public Action onOnMouseUp;

	void OnMouseUp ()
	{
		if (onOnMouseUp != null)
			onOnMouseUp ();
	}

	public Action onOnMouseUpAsButton;

	void OnMouseUpAsButton ()
	{
		if (onOnMouseUpAsButton != null)
			onOnMouseUpAsButton ();
	}

	public Action<GameObject> onOnParticleCollision;

	void OnParticleCollision (GameObject other)
	{
		if (onOnParticleCollision != null)
			onOnParticleCollision (other);
	}

	public Action<Collider> onOnTriggerEnter;

	void OnTriggerEnter (Collider other)
	{
		if (onOnTriggerEnter != null)
			onOnTriggerEnter (other);
	}

	public Action<Collider2D> onOnTriggerEnter2D;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (onOnTriggerEnter2D != null)
			onOnTriggerEnter2D (other);
	}

	public Action<Collider> onOnTriggerExit;

	void OnTriggerExit (Collider other)
	{
		if (onOnTriggerExit != null)
			onOnTriggerExit (other);
	}

	public Action<Collider2D> onOnTriggerExit2D;

	void OnTriggerExit2D (Collider2D other)
	{
		if (onOnTriggerExit2D != null)
			onOnTriggerExit2D (other);
	}

	public Action<Collider> onOnTriggerStay;

	void OnTriggerStay (Collider other)
	{
		if (onOnTriggerStay != null)
			onOnTriggerStay (other);
	}

	public Action<Collider2D> onOnTriggerStay2D;

	void OnTriggerStay2D (Collider2D other)
	{
		if (onOnTriggerStay2D != null)
			onOnTriggerStay2D (other);
	}

	public Action onReset;

	void Reset ()
	{
		if (onReset != null)
			onReset ();
	}

	public Action onOnAnimatorMove;

	void OnAnimatorMove ()
	{
		if (onOnAnimatorMove != null)
			onOnAnimatorMove ();
	}

	public Action<int> onOnAnimatorIK;

	void OnAnimatorIK (int layerIndex)
	{
		if (onOnAnimatorIK != null)
			onOnAnimatorIK (layerIndex);
	}
}
