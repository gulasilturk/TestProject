using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //[Range(50,500)]
    public float sens;
    public Transform body;
    public float speed=0f;

    float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime*speed;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime*speed;

        xRot -= rotY;
        xRot = Mathf.Clamp(xRot, -40f, 40f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        body.Rotate(Vector3.up * rotX);

       




    }
}
