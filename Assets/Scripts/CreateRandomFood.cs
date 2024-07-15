using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomFood : MonoBehaviour
{
    public GameObject thisFood;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;
    public float spawnChance = 0.5f;
    void Start()
    {
        spawnAreaMin = GetComponent<Collider>().bounds.min;
        spawnAreaMax = GetComponent<Collider>().bounds.max;
        StartCoroutine(SpawnRandomObject());
    }

    
    IEnumerator SpawnRandomObject(){
        while(true){
            yield return new WaitForSeconds(1f);
            if(Random.value < spawnChance){
                Vector3 randomPosition = new Vector3(
                    Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                    Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                    Random.Range(spawnAreaMin.z, spawnAreaMax.z)
                );
                Ray ray = new Ray(randomPosition + Vector3.up * 10, Vector3.down);
                
                if(Physics.Raycast(ray, out RaycastHit hit, 20) && hit.collider.tag == "Ground" && hit.collider.tag != "Player"){
                    Instantiate(thisFood, randomPosition, Quaternion.identity);
                }
            }
        }

    }
}
