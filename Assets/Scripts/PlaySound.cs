using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Basket")
        {
            Debug.Log("intersect");
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
                alreadyPlayed = true;
            }
        }
    }
}