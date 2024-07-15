using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;

    public int damage = 50;
    public float currentHealth;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        currentHealth = maxHealth;
        PlayerPrefs.SetFloat("Health", currentHealth);
    }

    public void TakeDamage(float amount)
    {
        Debug.Log(PlayerPrefs.GetInt("Health"));
        currentHealth -= amount;
        // if (currentHealth <= 0)
        // {
        //     Die();
        // }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
