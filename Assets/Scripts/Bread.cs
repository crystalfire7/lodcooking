using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour, Grillable
{
    public Material grilled;
    public float grillTime = 0.0f;
    public bool grilling = false;
    public bool stuck = false;
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
        if(!stuck && collision.gameObject.tag == "Stickable") {
            stuck = true;
            collision.gameObject.BroadcastMessage("Stick", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }
    void FixedUpdate() {
        if(grilling) {
            grillTime -= Time.deltaTime;
        }
        if(grillTime <= 0) {
            var mats = GetComponent<Renderer>().materials;
            mats[1] = grilled;
            GetComponent<Renderer>().materials = mats;
        }
    }
}
