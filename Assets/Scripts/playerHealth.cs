using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public bool isAlive = true;

    public TextMeshProUGUI hp;
    public GameObject gameOverUI;

    private Animator anim;
    
    void Start()
    {
        currentHealth = maxHealth;
        UpdatehpUI();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
            anim.SetTrigger("hit");
        }
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            TakeDamage(1);
            anim.SetTrigger("hit");
        }
    }

    void TakeDamage(int amount)
    {
        if (isAlive)  
        {
            currentHealth -= amount;
            UpdatehpUI();

            if (currentHealth <= 0)
            {
                Die();
                gameOverUI.SetActive(true);
                
            }
        }
    }

    void UpdatehpUI()
    {
        if (hp != null)
        {
            hp.text = "HP: " + currentHealth; 
        }
    }

    void Die()
    {
        isAlive = false;
        Destroy(gameObject);
        
    }

}
