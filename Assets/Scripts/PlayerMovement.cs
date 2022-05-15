using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;

    public CharacterController2D controller;

    float horizontalMove = 0f;
    public Joystick joystick;

    public float runSpeed = 40f;

    bool jump = false;
    
    
    // Update is called once per frame
    void Update()
    {
      horizontalMove = joystick.Horizontal * runSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void Jump()
    {
        jump = true;
        FindObjectOfType<AudioController>().Play("Jump", 1);
        controller.CreateDust();
    }
   
}
