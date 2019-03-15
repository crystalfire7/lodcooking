using UnityEngine;
using System.Collections;

public class PlaySound2 : MonoBehaviour
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
        if (other.tag == "Potato")
        {
            Debug.Log("intersect");
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
              
            }
        }
    }
}