using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddZAbility : MonoBehaviour
{
    
    GameObject player = PlayerInfo.player;
    void OnTriggerEnter(Collider other){
        if(other.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            if(PlayerInfo.counter_Z == 0) {
                abilities.Z_Event.AddListener(other.GetComponent<ShootBullet>().Shoot);
            }
            else {
                other.GetComponent<ShootBullet>().Upgrade();
            }
            PlayerInfo.counter_Z++;
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
