using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCAbility : MonoBehaviour
{
    GameObject player = PlayerInfo.player;
    void OnCollisionEnter(Collision other){
        if(other.collider.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            if(PlayerInfo.counter_C == 0) {
                abilities.C_Event.AddListener(other.collider.GetComponent<Teleport>().Teleportation);
            }
            else {
                other.collider.GetComponent<Teleport>().Upgrade();
            }
            PlayerInfo.counter_C++;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
