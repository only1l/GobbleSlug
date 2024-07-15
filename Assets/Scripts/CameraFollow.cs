using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 cameraOffset;
    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
