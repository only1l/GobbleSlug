using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float force = 20.0f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();

            Vector3 direction = (other.transform.position - transform.position).normalized * 3;
            enemyRb.AddForce(-direction * force, ForceMode.Impulse);
            // Vector3 direction = gameObject.transform.forward;
            // enemyRb.AddForce(-direction * force, ForceMode.Impulse);
            // playerRb.AddForce(direction * force, ForceMode.Impulse);

            GiveDamage.giveDamage(gameObject, other.gameObject);

        }

        if(!other.collider.CompareTag("Bullet")){
            Destroy(gameObject);
        }
    }
}
