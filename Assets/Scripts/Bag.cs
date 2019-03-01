using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bag : MonoBehaviour
{
    private int BreadNumber = 0;
    private int CheeseNumber = 0;
    private int OrangeNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other) {

            if (other.tag == "Bread")
            {
                BreadNumber += 1;
                Destroy(other.gameObject);
                Debug.Log("Bread was placed in the basket");
            }
            if (other.tag == "Cheese")
            {
                CheeseNumber += 1;
                Destroy(other.gameObject);
                Debug.Log("Cheese was placed in the basket");
            }

        }

        if (OrangeNumber > 0)
        {
            SceneManager.LoadScene("Shopping");
        }
        if (BreadNumber == 2 && CheeseNumber == 1){
            SceneManager.LoadScene("Kitchen");
        }
        
    }
}
