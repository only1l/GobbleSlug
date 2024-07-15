using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movePlayer : MonoBehaviour
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

    public Transform player;
    public float speed = 3f;

    public Vector3 cameraOffset;

    void Start(){
        cameraOffset = transform.position - player.position;
    }

    void Update(){
        Vector3 lookDirection = player.forward;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = (lookDirection * y + player.right * x).normalized;

        player.GetComponent<Rigidbody>().MovePosition(player.position + movement * speed * Time.deltaTime);

        transform.position = player.position + cameraOffset;
    }
}