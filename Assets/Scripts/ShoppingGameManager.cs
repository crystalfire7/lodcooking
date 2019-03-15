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
	void Awake () {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
		} else {
			instance = this;
		}
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        bag = GameObject.FindGameObjectWithTag("Basket").GetComponent<Bag>();
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
		if(bag.isDone) {
			//if bag contains all items, play victory sound and screen prefab
			SceneManager.LoadScene(kitchenName);
		}
		if(timer.timeUp) {
			//if timer runs out, and bag doesnt have all items, play fail sound and prefab
			SceneManager.LoadScene("Start");
		}
	}
}
