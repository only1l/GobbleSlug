using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public float force = 10.0f;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody enemyRb = GetComponent<Rigidbody>();
            Rigidbody playerRb = other.gameObject.GetComponent<Rigidbody>();

            Vector3 direction = (other.transform.position - transform.position).normalized * 3;
            enemyRb.AddForce(-direction * force, ForceMode.Impulse);
            playerRb.AddForce(direction * force, ForceMode.Impulse);
            // Vector3 direction = gameObject.transform.forward;
            // enemyRb.AddForce(-direction * force, ForceMode.Impulse);
            // playerRb.AddForce(direction * force, ForceMode.Impulse);

            GiveDamage.giveDamage(gameObject, other.gameObject);
        }

        
    }
}
