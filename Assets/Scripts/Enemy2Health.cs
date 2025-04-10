using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
    private int health = 3;
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
            health--;
            anim.SetTrigger("death");
            soundManagerAudioSource.PlayOneShot(deathSound);

            if (health <= 0)
            {            
                Die();
                soundManagerAudioSource.PlayOneShot(deathSound);
                anim.SetTrigger("death");
                
            }
        }
    }

    void Die()
    {
        Destroy(gameObject,0.05f);
    }
}

