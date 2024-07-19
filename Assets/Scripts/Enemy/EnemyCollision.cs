using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCollision : MonoBehaviour
{
    
    public Animator animator;
    public float force = 10.0f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Stats enemyStats = GetComponent<Stats>();
            Stats playerStats = other.gameObject.GetComponent<Stats>();

            Rigidbody enemyRb = GetComponent<Rigidbody>();
            Rigidbody playerRb = other.gameObject.GetComponent<Rigidbody>();

            Vector3 direction = (other.transform.position - transform.position).normalized * 3;
            enemyRb.AddForce(-direction * playerStats.knocknackForce, ForceMode.Impulse);
            playerRb.AddForce(direction * enemyStats.knocknackForce, ForceMode.Impulse);
            GiveDamage.giveDamage(gameObject, other.gameObject);
            animator.SetTrigger("Hit");
        }
    }


    
}
