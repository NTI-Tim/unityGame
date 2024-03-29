// Imports & modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script start
public class RedWeapon : MonoBehaviour
{
    // Variables
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;

    // Fire logic for red bullet
    public void FireR()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }
}
// Script end