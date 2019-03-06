using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeText : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGrilledCheese;
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
        string display = "TO DO: \n\n";
        List<string> taskList = GameManager.Instance.RecipeObj.tasks;
        foreach (string task in taskList) {
            display += taskToInstruction(task) + "\n\n";
        }
        instructions.text = display;
    }
    public string taskToInstruction(string task) {
        if(task == "stack" && isGrilledCheese) {
            return "Stack the ingredients in the following order from bottom to top: bread, cheese, bread.";
        }
        if(task == "grill" && isGrilledCheese) {
            return "Grill the sandwich for 10 seconds.";
        }
        return "";
    }
}
