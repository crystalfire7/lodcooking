using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Debug.Log("something has entered");
        collider.gameObject.BroadcastMessage("Chop", gameObject, SendMessageOptions.DontRequireReceiver);
    }
}
