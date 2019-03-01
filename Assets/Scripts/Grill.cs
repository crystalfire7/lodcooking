﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grill : MonoBehaviour
{
    public bool isOn;

    void Start()
    {
        isOn = true;
    }

    void OnCollisionEnter(Collision collision) {
        if(isOn) {
            collision.gameObject.SendMessage("Grill", SendMessageOptions.DontRequireReceiver);
        }
    }

    void OnCollisionExit(Collision collision) {
        if(isOn) {
            collision.gameObject.SendMessage("Stop", SendMessageOptions.DontRequireReceiver);
        }
    }
}
