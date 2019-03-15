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
        SwitchScene();
    }

    public void SwitchScene() {
		SceneManager.LoadScene(shoppingScene);
	}
}
