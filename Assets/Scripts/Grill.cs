using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grill : MonoBehaviour
{
    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    void OnTriggerStay(Collider collider) {
        if(collider.gameObject.tag == "Grillable") {
			Grillable g = collider.gameObject.GetComponent<Grillable>();
			g.Grill();	
		}
    }
}
