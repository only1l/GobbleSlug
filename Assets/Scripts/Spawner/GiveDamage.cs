using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour
{
    public static void giveDamage(GameObject friend, GameObject enemy){
        Health enemyHealth = enemy.GetComponent<Health>();
        Health playerHealth = friend.gameObject.GetComponent<Health>();

        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(playerHealth.HealthStats.damage);
        }

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(enemyHealth.HealthStats.damage);
        }
    }
}
