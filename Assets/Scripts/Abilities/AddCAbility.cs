using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCAbility : MonoBehaviour
{
    GameObject player = PlayerInfo.player;
    void OnTriggerEnter(Collider other){
        if(other.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            if(PlayerInfo.counter_C == 0) {
                abilities.C_Event.AddListener(other.GetComponent<Teleport>().Teleportation);
            }
            else {
                other.GetComponent<Teleport>().Upgrade();
            }
            PlayerInfo.counter_C++;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
