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
     
        animator.SetBool("ispassed", true);
    }


    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        animator.SetBool("ispassed", true);

    //    }
    //}

    void OnTriggerStay(Collider other)
    {

            if (Input.GetKeyDown(KeyCode.E))
         {
            if (other.gameObject.tag == "Player")
            {
                animator.SetBool("ispassed", false);

            }
        }
      
    }

        private void OnTriggerExit(Collider other)
    {
        animator.SetBool("ispassed", true);
    }

}
