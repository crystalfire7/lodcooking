using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeText : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGrilledCheese;
    public bool isFries;
    Text instructions;
    void Start()
    {
        instructions = GetComponent<Text>();
        string display = "";
        List<string> taskList = GameManager.Instance.RecipeObj.tasks;
        foreach (string task in taskList) {
            display += taskToInstruction(task) + "\n\n";
        }
        instructions.text = display;
    }

    void Update()
    {
        string display = "";
        List<string> taskList = GameManager.Instance.RecipeObj.tasks;
        foreach (string task in taskList) {
            display += taskToInstruction(task) + "\n\n";
        }
        instructions.text = display;
    }
    public string taskToInstruction(string task) {
        if(task == "stack" && isGrilledCheese) {
            return "- Stack the ingredients in the following order from bottom to top: bread, cheese, bread.";
        }
        if(task == "grill" && isGrilledCheese) {
            return "- Grill the sandwich for 10 seconds.";
        }
        if(task == "fry" && isFries) {
            return "- Grill the fries for 10 seconds.";
        }
        if(task == "cut" && isFries) {
            return "- Cut 10 fries from your potato.";
        }
        return "";
    }
}
