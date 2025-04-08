using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform firePoint;
    public float firePower = 20f;

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletObject, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * firePower, ForceMode2D.Impulse);
    }
}
