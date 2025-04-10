using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    private AudioSource audioSource; 
    public AudioClip deathSound; 

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    
    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathSound);
    }
}
