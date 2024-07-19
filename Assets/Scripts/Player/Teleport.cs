using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float tpForce = 10;
    public void Teleportation(){
        Transform currentPosition = PlayerInfo.player.transform;
        Vector3 tpPosition = currentPosition.position + currentPosition.forward * tpForce;
        PlayerInfo.player.transform.position = tpPosition;
    }

    public void Upgrade(){
        tpForce += 2.5f;
    }
}
