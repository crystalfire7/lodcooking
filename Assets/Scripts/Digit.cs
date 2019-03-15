using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Digit : MonoBehaviour
{
    public bool isMin;
    public bool is4th;
    public bool is3rd;
    Text time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float timeL = GameManager.Instance.TimerObj.timeLeft;
        if(timeL > 0) {
            int timeInt = (int) Mathf.Floor(timeL);
            if(isMin) {
                int min = timeInt / 60;
                time.text = "" + min;
            } else {
                int sec = timeInt % 60;
                if(is3rd) {
                    time.text = "" + sec / 10;
                } else {
                    time.text = "" + sec % 10;
                }
            }
        }
    }
}
