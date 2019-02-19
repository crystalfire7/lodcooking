using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HTC.UnityPlugin.ColliderEvent;
using HTC.UnityPlugin.Utility;

public class ToPizza : MonoBehaviour, IColliderEventHoverEnterHandler
{
    public void OnColliderEventHoverEnter(ColliderHoverEventData eventData)
    {
        SceneManager.LoadScene("Shopping");
    }
}
