using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;

    CharacterController playerCollider;
    float originalHeight;
    public float reducedHeight;



    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    private void Start()
    {
        playerCollider = GetComponent<CharacterController>();
        originalHeight = playerCollider.height;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
        
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
              Crouch();
            speed = 3f;
            jumpHeight = 0f;
        }

          
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            GoUp();
            speed = 5f;
            jumpHeight = 1f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 7f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        
    }
    void Crouch()
    {
        playerCollider.height = reducedHeight;
    }
    void GoUp()
    {
        playerCollider.height = originalHeight;
    }

}
