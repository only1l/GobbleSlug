using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddXAbility : MonoBehaviour
{
    
    GameObject player = PlayerInfo.player;
    void OnTriggerEnter(Collider other){
        if(other.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            if(PlayerInfo.counter_X == 0) {
                abilities.X_Event.AddListener(other.GetComponent<Shield>().SpawnShields);
            }
            else {
                other.GetComponent<Shield>().Upgrade();
            }
            PlayerInfo.counter_X++;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
