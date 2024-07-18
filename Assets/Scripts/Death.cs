using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    public UnityEvent dieEvent;
    public Health health;

    void Update(){
        if(health.HealthStats.currentHealth <= 0){
            dieEvent.Invoke();
            Destroy(gameObject);
        }
    }

}
