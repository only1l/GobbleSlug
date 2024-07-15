using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddZAbility : MonoBehaviour
{
    GameObject player = PlayerInfo.player;
    void OnCollisionEnter(Collision other){
        if(other.collider.TryGetComponent<ZXC_Abilities>(out ZXC_Abilities abilities)){
            abilities.Z_Event.AddListener(other.collider.GetComponent<ShootBullet>().Shoot);
            Destroy(gameObject);
        }
        else{
            return;
        }
    }
}
