using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // private Rigidbody rb;
    // public float speed = 0.5f;
    // private Vector3 moveVector;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // void Update()
    // {
    //     moveVector.x = Input.GetAxis("Horizontal");
    //     moveVector.z = Input.GetAxis("Vertical");
    //     rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    // }
    public Rigidbody rb;
    public float speed = 5f;
    public void Move(){
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        Vector3 move = transform.right * x + transform.forward * z;
        rb.MovePosition(rb.position + move * Time.deltaTime);
    }
}