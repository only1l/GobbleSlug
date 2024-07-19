using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZEnemyBehaviour : MonoBehaviour
{
    public Shield ShieldBehaviour;
    void Start()
    {
        ShieldBehaviour.SpawnShields();
    }
}
