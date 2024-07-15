using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
    public UnityEvent Control_Events;
    public Jump jump;
    public MouseLook mouseLook;
    public Stats playerStatistic;
    public float sprintSpeed;
    public float jumpForce = 5f;
    public Movement movement;

    void Start()
    {
        Control_Events.AddListener(UpdateSpeed);
        Control_Events.AddListener(mouseLook.Look);
        Control_Events.AddListener(SprintPlayer);
        Control_Events.AddListener(movement.Move);
        Control_Events.AddListener(jump.CheckJump);
        UpdateSpeed();
        movement.rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Control_Events.Invoke();
    }

    void UpdateSpeed(){
        movement.speed = playerStatistic.speed;
        sprintSpeed = movement.speed * 2;
    }


    void SprintPlayer(){
        if(Input.GetKey(KeyCode.LeftShift) && playerStatistic.stamina>0){
            Debug.Log("Run");
            movement.speed = sprintSpeed;
            playerStatistic.stamina -= 10 * Time.deltaTime;
            if(playerStatistic.stamina <= 0){
                StartCoroutine(WaitForSprint());
            }
        }
        else if(playerStatistic.stamina <= playerStatistic.maxStamina){
            playerStatistic.stamina += 10 * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Ground")){
            jump.jumpCount = jump.maxJumpCount;
        }
    }


    IEnumerator WaitForSprint(){
        Control_Events.RemoveListener(SprintPlayer);
        yield return new WaitForSeconds(2f);
        Control_Events.AddListener(SprintPlayer);
    }
}
