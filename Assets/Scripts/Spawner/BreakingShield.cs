using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakingShield : MonoBehaviour
{
    public Health health;
    void Update(){
        if(health.HealthStats.currentHealth <= 0){
            Destroy(gameObject);
        }
    }

}