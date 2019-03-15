using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HTC.UnityPlugin.ColliderEvent;
using HTC.UnityPlugin.Utility;

public class ToShopping : MonoBehaviour, IColliderEventHoverEnterHandler
{
    public string shoppingScene;
    public void OnColliderEventHoverEnter(ColliderHoverEventData eventData)
    {
        StartCoroutine(SwitchScene());
    }

    IEnumerator SwitchScene() {
		StartManager.Instance.AnimatorObj.SetTrigger("SwitchScene");
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(shoppingScene);
	}
}
