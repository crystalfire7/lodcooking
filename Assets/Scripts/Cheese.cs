using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour, Stickable
{
    public GameObject bc;
    public GameObject bcb;
    public int numBread = 0;

    GameObject bcRef;
    public void Stick(GameObject stickChild) {
        Debug.Log("create" + numBread);
        //spawn merged prefab
        if(numBread == 0) {
            GameObject re = Instantiate(bc, stickChild.transform.position, stickChild.transform.rotation);
            re.BroadcastMessage("Create", re);
            Destroy(stickChild);
            Destroy(gameObject);
        }
        if(numBread == 1) {
            Vector3 pos = stickChild.transform.position;
            Quaternion rot = stickChild.transform.rotation;
            Destroy(stickChild);
            Destroy(bcRef);
            Instantiate(bcb, pos, rot);
            Debug.Log("create2");
        }
    }

    public void Create(GameObject re) {
        bcRef = re;
    }
}
