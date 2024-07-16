using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public Stats HealthStats;
    public float currentHealth;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        currentHealth = HealthStats.maxHealth;
        PlayerPrefs.SetFloat("Health", currentHealth);
    }

    public void TakeDamage(float amount)
    {
        Debug.Log(PlayerPrefs.GetInt("Health"));
        currentHealth -= amount;
    }
}
