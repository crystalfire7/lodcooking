using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private static GameManager instance;
	public static GameManager Instance {
		get {
			return instance;
		}
	}

	Grill grill;

	void Awake () {
		grill = GameObject.FindGameObjectWithTag("Grill").GetComponent<Grill>();
	}

	public Grill GrillObj {
		get {
			return grill;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
