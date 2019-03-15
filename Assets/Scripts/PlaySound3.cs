using UnityEngine;
using System.Collections;

public class PlaySound3 : MonoBehaviour
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
        if (other.tag == "Fries")
        {
            Debug.Log("intersect");
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
              
            }
        }
    }
}