using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Shake shake;
    public GameObject hitEffectPrefab;
    public GameObject hitEffectPrefab2;
    public GameObject hitEffectPrefab3;

   

    void Start()
    {
        
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            
            Instantiate(hitEffectPrefab3, transform.position, Quaternion.identity);
            Instantiate(hitEffectPrefab2, transform.position, Quaternion.identity);
            ScoreManager.instance.AddPoint2();
            shake.CamShake2();
            Destroy(gameObject);
        }
        else
        {
            
            Instantiate(hitEffectPrefab3, transform.position, Quaternion.identity);
            Instantiate(hitEffectPrefab, transform.position, Quaternion.identity);
            ScoreManager.instance.AddPoint1();
            shake.CamShake();
            
            Destroy(gameObject);
        }
            
    }
    
}
