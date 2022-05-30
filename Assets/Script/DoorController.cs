using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    public bool ishere;
 

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

        animator.SetBool("ispassed", true);
    }


    void Update()
    {
        ishere = true;

        if (Input.GetKeyDown(KeyCode.E) && ishere)
        {

            animator.SetBool("ispassed", false);
            Debug.Log("!");
        }
    }






}
//   private void OnTriggerExit(Collider other)
//    {
       
//            if (!ishere||Input.GetKeyDown(KeyCode.E))
//            {
//            Debug.Log("&");
//            animator.SetBool("ispassed", true);
//            }

        
   
//    }

//}
