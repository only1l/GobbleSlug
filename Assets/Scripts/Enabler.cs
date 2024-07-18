using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enabler : MonoBehaviour
{
    public NavMeshAgent agent;
    public GoTo goTo;
    void Update(){
        if(!agent.enabled){
            if(GetComponent<Rigidbody>().velocity.magnitude == 0){
                Enable();
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" ||
            other.gameObject.tag == "Shield" ||
            other.gameObject.tag == "Bullet" )
        {
            Disable();
        }
    }

    void Disable(){
        goTo.enabled = false;
        agent.enabled = false;
    }
    
    public void Enable(){
        agent.enabled = true;
        goTo.enabled = true;
    }
}
