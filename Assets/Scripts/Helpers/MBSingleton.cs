using System.Collections;
using UnityEngine;

/// <summary>
/// A singleton of a Unity Component (Mostly a MonoBehaviour); Does not get spawned if not there
/// </summary>
/// <typeparam name="T">A Unity Component</typeparam>
public class MBSingleton<T> : MonoBehaviour where T : Component {

	public static T Instance { get; private set; }
	
	protected virtual void Awake () {
		if (Instance == null && enabled) {
			Instance = this as T;
			//DontDestroyOnLoad (this);
		} else {
			Destroy (this);
		}
	}
}
