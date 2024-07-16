using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        if(GetComponent<Stats>()){
            GiveDamage.giveDamage(gameObject, other.gameObject);
            Destroy(gameObject);
        }
    }
}
