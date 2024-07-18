using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddXAbility : MonoBehaviour
{
    
    GameObject player = PlayerInfo.player;
    void OnCollisionEnter(Collision other){
        if(other.collider.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            abilities.X_Event.AddListener(other.collider.GetComponent<Shield>().SpawnShields);
            PlayerInfo.counter_X++;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
