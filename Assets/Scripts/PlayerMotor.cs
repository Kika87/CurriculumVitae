using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    private bool isGrounded;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0) //aby nezostal zaseknuty v podlahe
            playerVelocity.y = -2f;
        controller.Move(playerVelocity * Time.deltaTime);
        UnityEngine.Debug.Log(playerVelocity.y);
    }

    public void Jump()
    {
        if(isGrounded) //zist�me si, �i je player uzemnen�
        {
            playerVelocity.y = (float)Math.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
