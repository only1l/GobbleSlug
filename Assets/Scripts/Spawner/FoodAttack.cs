using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAttack : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        Stats pStats;
        if(other.TryGetComponent<Stats>(out pStats)){
            pStats.damage += 5f;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
