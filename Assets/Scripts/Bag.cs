using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bag : MonoBehaviour
{
    public List<string> inBag;
    public List<string> needed;
    public bool isDone = false;

    private void Start()
    {
        isDone = false;
    }

    private void Update()
    {
        List<string> temp = new List<string>(needed);
        foreach(string item in inBag)
        {
            temp.Remove(item);
        }
        if (temp.Count == 0)
        {
            isDone = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        string name = LayerMask.LayerToName(other.gameObject.layer);
        if (name == "Food")
        {
            inBag.Add(other.tag);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        string name = LayerMask.LayerToName(other.gameObject.layer);
        if (name == "Food")
        {
            inBag.Remove(other.tag);
        }
    }
}
