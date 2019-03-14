using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    public bool isOn;

    void Start()
    {
        isOn = true;
    }

    void OnTriggerEnter(Collider collider) {
        if(isOn) {
            Debug.Log(collider.gameObject);
            collider.gameObject.BroadcastMessage("Frying", SendMessageOptions.DontRequireReceiver);
        }
    }

    void OnTriggerExit(Collider collider) {
        if(isOn) {
            collider.gameObject.BroadcastMessage("Stop", SendMessageOptions.DontRequireReceiver);
        }
    }
}
