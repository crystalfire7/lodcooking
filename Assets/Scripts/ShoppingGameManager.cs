using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShoppingGameManager : MonoBehaviour {
	private static ShoppingGameManager instance;
	public static ShoppingGameManager Instance {
		get {
			return instance;
		}
	}

	Timer timer;
    Bag bag;
	void Awake () {
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        bag = GameObject.FindGameObjectWithTag("Basket").GetComponent<Bag>();
    }

	// Update is called once per frame
	void Update () {
		if(bag.isDone) {
			//if bag contains all items, play victory sound and screen prefab
			SceneManager.LoadScene("Kitchen");
		}
		if(timer.timeUp) {
			//if timer runs out, and bag doesnt have all items, play fail sound and prefab
			SceneManager.LoadScene("Start");
		}
	}
}
