using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitFood : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Plate") {
            //judge plate, end game
            GameManager.Instance.endGame();
        }
    }
}
