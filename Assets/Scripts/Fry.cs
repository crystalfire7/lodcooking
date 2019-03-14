using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fry : MonoBehaviour
{
    public Material fried;
    public float fryTime = 0.0f;
    public bool frying = false;
    public bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        fryTime = 10.0f;
        frying = false;
    }

    public void Frying() {
        frying = true;
    }

    public void Stop() {
        frying = false;
    }
   
    void FixedUpdate() {
        if(frying) {
            fryTime -= Time.deltaTime;
        }
        if(fryTime <= 0 && !finished) {
            finished = true;
            var mats = GetComponent<Renderer>().materials;
            mats[0] = fried;
            GetComponent<Renderer>().materials = mats;
            GameManager.Instance.RecipeObj.finishFry();
        }
    }
}
