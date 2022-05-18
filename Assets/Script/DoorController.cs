using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
     
        animator.SetBool("ispassed", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("ispassed", true);
      
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("ispassed", false);
    }

}
