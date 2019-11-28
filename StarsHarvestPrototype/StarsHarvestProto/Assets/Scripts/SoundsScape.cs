using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScape : MonoBehaviour
{
    private AudioSource PlayerAudioSource;
    public AudioClip AudioPickUp;
    private float ScoreKeeperAudio;

    //Gets the players audiocomponent(audiosource)
    private void Start()
    {
        PlayerAudioSource = GetComponent<AudioSource>();
    }

    // Checks if the score updates, if score updates, play the sound given by calling the proper function.
    void Update()
    {
        if (ScoreKeeperAudio != CloudPickUp.ScoreFromCloud)
        {
            PickUpAudio();
            PlayerAudioSource.Play();
            ScoreKeeperAudio = CloudPickUp.ScoreFromCloud;
        }
    }

    private void PickUpAudio()
    {
        PlayerAudioSource.clip = AudioPickUp;
    }
}
