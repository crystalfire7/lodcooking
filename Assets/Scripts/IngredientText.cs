using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IngredientText : MonoBehaviour
{
    Text instructions;
    void Start()
    {
        instructions = GetComponent<Text>();
        string display = "";
        
        List<string> temp = new List<string>(ShoppingGameManager.Instance.BagObj.needed);
        foreach(string item in ShoppingGameManager.Instance.BagObj.inBag)
        {
            temp.Remove(item);
        }
        foreach (string task in temp) {
            display += taskToInstruction(task) + "\n\n";
        }
        instructions.text = display;
    }

    void Update()
    {
        string display = "";
        
        List<string> temp = new List<string>(ShoppingGameManager.Instance.BagObj.needed);
        foreach(string item in ShoppingGameManager.Instance.BagObj.inBag)
        {
            temp.Remove(item);
        }
        foreach (string task in temp) {
            display += taskToInstruction(task) + "\n\n";
        }
        instructions.text = display;
    }
    public string taskToInstruction(string task) {
        return "- " + task;
    }
}
