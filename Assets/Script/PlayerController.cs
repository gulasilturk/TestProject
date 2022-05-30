using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static CharacterController CharacterController;
    public CharacterController controller;
    public GameObject Bullet;
    public Transform cam;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;

    CharacterController playerCollider;
    float originalHeight;
    public float reducedHeight;
    float zaman;


    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    private void Start()
    {
        playerCollider = GetComponent<CharacterController>();
        originalHeight = playerCollider.height;
        zaman = 0;
    }

    void Update()
    {
        #region Gravity
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        #endregion
        #region Movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        #endregion
        #region Shooter


        if (Input.GetKey(KeyCode.B))
        {
            if (zaman >= 0.5)
            {
                GameObject ShooterObject = Instantiate(Bullet, new Vector3(transform.position.x,1f,transform.position.z), Quaternion.Euler(cam.transform.eulerAngles.x, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z));
                ShooterObject.GetComponent<SphereCollider>().isTrigger = true;
                //ornekobjem.gameObject.CompareTag("Fire");
                ShooterObject.AddComponent<Rigidbody>();
                ShooterObject.GetComponent<Rigidbody>().isKinematic = true;
                zaman = 0;
            }
            else
            {
                zaman += Time.deltaTime;
            }
        }





        #endregion
        #region Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {

            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        #endregion

        #region Crouch
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
        #endregion

        #region Run
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 7f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        #endregion


        void Crouch()
        {
            playerCollider.height = reducedHeight;
        }
        void GoUp()
        {
            playerCollider.height = originalHeight;
        }

    }
}
