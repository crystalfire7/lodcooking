using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShoppingGameManager : MonoBehaviour {
	private static ShoppingGameManager instance;
    public string kitchenName;
	public static ShoppingGameManager Instance {
		get {
			return instance;
		}
	}

	public GameObject victoryPrefab;
	public GameObject defeatPrefab;
	Timer timer;
    Bag bag;
	Animator animator;
	public bool ended = false;
	void Awake () {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
		} else {
			instance = this;
		}
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        bag = GameObject.FindGameObjectWithTag("Basket").GetComponent<Bag>();
		animator = GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>();
    }
	public Timer TimerObj {
		get {
			return timer;
		}
	}

	public Bag BagObj {
		get {
			return bag;
		}
	}

	// Update is called once per frame
	void Update () {
		if((bag.isDone || timer.timeUp) && !ended) {
			//if timer runs out, play timer sound and prefab
			endGame();
		}
	}

	public void endGame() {
		if(bag.isDone) {
			//win ui
			ended = true;
			Instantiate(victoryPrefab, new Vector3(0.03142f, 1.60144f, -1.107f), Quaternion.Euler(0, -90, 0));
			StartCoroutine(SwitchScene());
		} else {
			ended = true;
			//fail ui
			Instantiate(defeatPrefab, new Vector3(0.03142f, 1.60144f, -1.107f), Quaternion.Euler(0, -90, 0));
			StartCoroutine(SwitchScene());
		}
		
	}

	IEnumerator SwitchScene() {
		yield return new WaitForSeconds(2);
		animator.SetTrigger("SwitchScene");
		yield return new WaitForSeconds(2);
		if(bag.isDone) {
			SceneManager.LoadScene(kitchenName);
		} else {
			SceneManager.LoadScene("Start");
		}
	}
}
