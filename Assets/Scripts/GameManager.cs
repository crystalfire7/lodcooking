using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	private static GameManager instance;
	public static GameManager Instance {
		get {
			return instance;
		}
	}

	Grill grill;
	Timer timer;

	void Awake () {
		grill = GameObject.FindGameObjectWithTag("Grill").GetComponent<Grill>();
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
	}

	public Grill GrillObj {
		get {
			return grill;
		}
	}

	// Update is called once per frame
	void Update () {
		if(false /* cooking check */) {
			//if all cooking items complete, play victory sound and screen prefab
			SceneManager.LoadScene("Start");
		}
		if(timer.timeUp) {
			//if timer runs out, play fail sound and prefab
			SceneManager.LoadScene("Start");
		}
	}
}
