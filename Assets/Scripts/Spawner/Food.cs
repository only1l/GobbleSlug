using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        Stats pStats;
        if(other.TryGetComponent<Stats>(out pStats)){
            pStats.speed += 1f;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
