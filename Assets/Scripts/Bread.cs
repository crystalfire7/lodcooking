using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour, Grillable
{
    public float grillTime = 0.0f;
    public bool grilling = false;
    // Start is called before the first frame update
    void Start()
    {
        grillTime = 10.0f;
        grilling = false;
    }

    public void Grill() {
        grilling = true;
    }

    public void Stop() {
        grilling = false;
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject);
        collision.gameObject.SendMessage("Stick", gameObject, SendMessageOptions.DontRequireReceiver);
    }
    void FixedUpdate() {
        if(grilling) {
            grillTime -= Time.deltaTime;
        }
        if(grillTime <= 0) {

        }
    }
}
