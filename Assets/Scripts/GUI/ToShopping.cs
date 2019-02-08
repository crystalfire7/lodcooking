using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToShopping : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToShop);   
    }

    // Update is called once per frame
    void ToShop()
    {
        SceneManager.LoadScene("Shopping");
    }
}
