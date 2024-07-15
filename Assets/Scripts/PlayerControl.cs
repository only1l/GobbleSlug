using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
    public UnityEvent Control_Events;
    public Stats playerStatistic;
    public float speed;
    public float sprintSpeed;
    public float jumpForce = 5f;
    public float mouseSensitivity = 100f;
    Rigidbody rb;
    Camera playerCamera;
    float xRotation = 0f;
    bool IsGrounded = false;

    void Start()
    {
        Control_Events.AddListener(UpdateSpeed);
        Control_Events.AddListener(Look);
        Control_Events.AddListener(SprintPlayer);
        Control_Events.AddListener(MovePlayer);
        Control_Events.AddListener(JumpPlayer);
        UpdateSpeed();
        rb = GetComponent<Rigidbody>();
        playerCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Control_Events.Invoke();
    }

    void UpdateSpeed(){
        speed = playerStatistic.speed;
        sprintSpeed = speed * 2;
    }

    void JumpPlayer(){
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void Look(){
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f,90f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    void MovePlayer(){
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        Vector3 move = transform.right * x + transform.forward * z;
        rb.MovePosition(rb.position + move * Time.deltaTime);
    }

    void SprintPlayer(){
        if(Input.GetKey(KeyCode.LeftShift) && playerStatistic.stamina>0){
            Debug.Log("Run");
            speed = sprintSpeed;
            playerStatistic.stamina -= 10 * Time.deltaTime;
            if(playerStatistic.stamina <= 0){
                StartCoroutine(WaitForSprint());
            }
        }
        else if(playerStatistic.stamina <= playerStatistic.maxStamina){
            playerStatistic.stamina += 10 * Time.deltaTime;
        }
    }

    void OnCollisionStay(Collision other){
        if(other.gameObject.CompareTag("Ground")){
            IsGrounded = true;
        }
    }

    void OnCollisionExit(Collision other){
        IsGrounded = false;
    }

    IEnumerator WaitForSprint(){
        Control_Events.RemoveListener(SprintPlayer);
        yield return new WaitForSeconds(2f);
        Control_Events.AddListener(SprintPlayer);
    }
}
