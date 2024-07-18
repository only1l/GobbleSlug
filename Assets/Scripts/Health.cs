using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public Stats HealthStats;

    private void Start()
    {
        // DontDestroyOnLoad(gameObject);
        HealthStats.currentHealth = HealthStats.maxHealth;
    }

    public void TakeDamage(float amount)
    {
        HealthStats.currentHealth -= amount;
    }
}
