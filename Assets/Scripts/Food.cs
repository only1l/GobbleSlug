using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        Stats pStats;
        if(other.collider.TryGetComponent<Stats>(out pStats)){
            pStats.speed += 5f;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
