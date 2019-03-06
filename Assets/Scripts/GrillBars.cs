using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillBars : MonoBehaviour
{
    public Material hotbars;
    public Material regbars;

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.GrillObj.isOn) {
            GetComponent<Renderer>().material = hotbars;
        } else {
            GetComponent<Renderer>().material = regbars;
        }
    }
}
