using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour, Stickable
{
    public void Stick(GameObject stickChild) {
        stickChild.transform.parent = gameObject.transform;
    }
}
