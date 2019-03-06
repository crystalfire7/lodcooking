using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grill : MonoBehaviour
{
    public bool isOn;

    void Start()
    {
        isOn = true;
    }

    void OnTriggerEnter(Collider collider) {
        if(isOn && collider.gameObject.tag == "Grillable") {
            Debug.Log(collider.gameObject);
            collider.gameObject.BroadcastMessage("Grill", SendMessageOptions.DontRequireReceiver);
        }
    }

    void OnTriggerExit(Collider collider) {
        if(isOn && collider.gameObject.tag == "Grillable") {
            collider.gameObject.BroadcastMessage("Stop", SendMessageOptions.DontRequireReceiver);
        }
    }
}
