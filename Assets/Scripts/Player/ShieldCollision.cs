using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public float force = 5.0f;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.collider.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();

            Vector3 direction = (other.transform.position - PlayerInfo.player.transform.position).normalized * 3;
            enemyRb.AddForce(direction * force, ForceMode.Impulse);

            GiveDamage.giveDamage(gameObject, other.gameObject);

        }

    }
}
