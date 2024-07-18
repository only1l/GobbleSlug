using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorReturn : MonoBehaviour
{
    public GameObject Platform;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;

    void Start(){
        spawnAreaMin = Platform.GetComponent<Collider>().bounds.min;
        spawnAreaMax = Platform.GetComponent<Collider>().bounds.max;
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.TryGetComponent<Health>(out Health health)){
            health.HealthStats.currentHealth -= health.HealthStats.currentHealth/5;
            other.collider.transform.position = (spawnAreaMax + spawnAreaMin 
                                                  + Vector3.up * 5)/2;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
