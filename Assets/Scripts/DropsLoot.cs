using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsLoot : MonoBehaviour
{
    public GameObject loot;
    public Death onDeathEvent;
    
    void DropLoot(){
        Instantiate(loot, transform.position, Quaternion.identity);
    }
    void OnEnable(){
        onDeathEvent.dieEvent.AddListener(DropLoot);
    }
}
