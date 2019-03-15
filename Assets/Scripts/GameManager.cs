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

	public GameObject victoryPrefab;
	public GameObject defeatPrefab;
	public bool ended;
	Grill grill;
	Timer timer;
	Recipe recipe;
	Animator animator;
	void Awake () {
		ended = false;
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
		} else {
			instance = this;
		}
		grill = GameObject.FindGameObjectWithTag("Grill").GetComponent<Grill>();
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
		recipe = GameObject.FindGameObjectWithTag("Recipe").GetComponent<Recipe>();
		animator = GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>();
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
		if((recipe.isDone() || timer.timeUp) && !ended) {
			//if timer runs out, play timer sound and prefab
			endGame();
		}
	}

	public void endGame() {
		if(recipe.isDone()) {
			//win ui
			ended = true;
			Instantiate(victoryPrefab, new Vector3(0.03142f, 1.60144f, -1.184f), Quaternion.Euler(0, -90, 0));
			StartCoroutine(SwitchScene());
		} else {
			ended = true;
			//fail ui
			Instantiate(defeatPrefab, new Vector3(0.03142f, 1.60144f, -1.184f), Quaternion.Euler(0, -90, 0));
			StartCoroutine(SwitchScene());
		}
		
	}

	IEnumerator SwitchScene() {
		yield return new WaitForSeconds(4);
		animator.SetTrigger("SwitchScene");
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("Start");
	}
}
