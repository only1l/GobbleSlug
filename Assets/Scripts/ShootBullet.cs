using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public Transform player;
    public Stats bulletStats;
    void Start()
    {
        player = PlayerInfo.player.transform;
    }

    public void Shoot(){
        GameObject bullet = Instantiate(bulletPrefab, player.position + player.transform.forward * 2, Quaternion.identity);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = player.forward * bulletSpeed;
    }

    public void Upgrade(){
        bulletStats.damage += 10;
    }
} 
