using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour
{

	void Awake ()
	{
		InitGameMangager ();
	}

	public void InitGameMangager ()
	{
		string name = "GameManager";
		GameObject manager = GameObject.Find (name);
		if (manager == null) {
			manager = new GameObject (name);
			manager.name = name;

			AppFacade.Instance.StartUp ();   //启动游戏
		}
	}
}