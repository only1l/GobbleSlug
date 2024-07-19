using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public Animator animator;

    public void DeathAnimation(){
        animator.SetTrigger("Death");
        StartCoroutine(DeathWaiting());
    }

    IEnumerator DeathWaiting(){
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
