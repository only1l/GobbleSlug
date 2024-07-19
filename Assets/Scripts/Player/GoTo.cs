using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoTo : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;

    void OnEnable(){
        agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        agent.destination = PlayerInfo.player.transform.position;
    }
}
