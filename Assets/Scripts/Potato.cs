using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    public GameObject rawfry;
    public GameObject halfPotato;
    public int numFry = 0; //0 on new potato
    public int totalNumFry = 10; //10 for new potato, 5 for new half

    public void Chop(GameObject cutter) {
        Debug.Log("fry" + numFry);
        //spawn fry prefab
        Instantiate(rawfry, (cutter.transform.position + transform.position) / 2 , transform.rotation);
        numFry++;
        
        if(numFry == totalNumFry / 2) {
            Destroy(gameObject);
            GameObject half = Instantiate(halfPotato, transform.position, halfPotato.transform.rotation);
            half.BroadcastMessage("Half", totalNumFry);
        }

        if(numFry == totalNumFry) {
            Destroy(gameObject);
            GameManager.Instance.RecipeObj.finishChop();
        }
    }

    public void Half(int nFry) {
        numFry = nFry / 2;
        totalNumFry = nFry;
    }
}