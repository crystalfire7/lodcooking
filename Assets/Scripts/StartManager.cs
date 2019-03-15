using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {
	private static StartManager instance;

	public static StartManager Instance {
		get {
			return instance;
		}
	}

	Animator animator;

	void Awake () {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
		} else {
			instance = this;
		}
		animator = GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>();
    }
	public Animator AnimatorObj {
		get {
			return animator;
		}
	}
}
