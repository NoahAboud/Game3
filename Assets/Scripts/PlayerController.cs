using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Weapon weapon;
    public AudioClip shootSound;
    public AudioClip enemyDestroySound;

    private AudioSource audioSource;

    Vector2 moveDirection;
    Vector2 mousePosition;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0)) 
        {
            weapon.Fire(); 
            PlayShootSound(); 
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }

    void PlayShootSound()
    {
        
        if (audioSource != null && shootSound != null)
        {
            audioSource.PlayOneShot(shootSound); 
        }
    }
    public void PlayEnemyDestroySound()
    {
        if (audioSource != null && enemyDestroySound != null)
        {
            audioSource.PlayOneShot(enemyDestroySound);
        }
    }
}
