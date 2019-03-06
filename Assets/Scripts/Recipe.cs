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

    public bool isDone() {
        return tasks.Count == 0;
    }
}
