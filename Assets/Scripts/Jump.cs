using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int maxJumpCount = 2;
    public int jumpCount = 2;
    public float jumpForce = 10.0f;
    //public Collider legs;
    public Rigidbody rigidbody;
    // void Update(){
    //     if(Input.GetKeyDown(KeyCode.Space)){
    //         if(jumpCount <= 0){
    //             return;
    //         }

    //         jumpCount -= 1;
    //         rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    //     }
    // }

    public void CheckJump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            if(jumpCount <= 0){
                return;
            }

            jumpCount -= 1;
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
    void OnCollisionEnter(Collision other){
        if(other.collider.CompareTag("Ground")){
            jumpCount = maxJumpCount;
        }
    }
}