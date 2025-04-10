using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    private Animator anim;
    public AudioClip deathSound;
    private AudioSource soundManagerAudioSource;

    void Start()
    {
        soundManagerAudioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject,0.05f);
            soundManagerAudioSource.PlayOneShot(deathSound);
            anim.SetTrigger("death");
        }
    }
}
