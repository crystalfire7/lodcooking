using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    public List<string> tasks;
    public void finishStack() {
        if(tasks.Contains("stack")) {
            tasks.Remove("stack");
        }
    }

    public void finishGrill() {
        if(tasks.Contains("grill")) {
            tasks.Remove("grill");
        }
    }
    
    public void finishFry() {
        if(tasks.Contains("fry")) {
            tasks.Remove("fry");
        }
    }

    public void finishChop() {
        if(tasks.Contains("cut")) {
            tasks.Remove("cut");
        }
    }

    public bool isDone() {
        return tasks.Count == 0;
    }
}
