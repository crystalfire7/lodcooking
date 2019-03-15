using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public bool timeUp;
    public float timeLeft;

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0) {
            timeLeft = Mathf.Clamp(timeLeft - Time.deltaTime, 0, timeLeft);
        } else {
            timeUp = true;
        }
    }
}
