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
	Recipe recipe;

	void Awake () {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
		} else {
			instance = this;
		}
		grill = GameObject.FindGameObjectWithTag("Grill").GetComponent<Grill>();
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
		recipe = GameObject.FindGameObjectWithTag("Recipe").GetComponent<Recipe>();
	}

	public Grill GrillObj {
		get {
			return grill;
		}
	}

	public Timer TimerObj {
		get {
			return timer;
		}
	}

	public Recipe RecipeObj {
		get {
			return recipe;
		}
	}

	// Update is called once per frame
	void Update () {
		if(timer.timeUp) {
			//if timer runs out, play timer sound and prefab
			endGame();
		}
	}

	public void endGame() {
		if(recipe.isDone()) {
			//win ui
			Debug.Log("win");
			SceneManager.LoadScene("Start");
		} else {
			//fail ui
			SceneManager.LoadScene("Start");
		}
	}
}
