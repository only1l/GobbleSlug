using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsLoot : MonoBehaviour
{
    public List<GameObject> list;
    public Death onDeathEvent;
    
    void DropLoot(){
        for(int i = 0;i<list.Count;i++){
            if(Random.value < list[i].GetComponent<Loot>().chance){
                Instantiate(list[i], transform.position, Quaternion.identity);
            }
        }
    }
    void OnEnable(){
        onDeathEvent.dieEvent.AddListener(DropLoot);
    }
}
