using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    private bool lampIsClosed = true;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.tag == "Player")
            {
                OpenLamp();
   //GetComponent<Renderer>().material.color = new Color(255, 255, 0);
            }
        }
       
      
    }
    void OpenLamp()
    {
        if (lampIsClosed)
        {
            GetComponent<Renderer>().material.color = new Color(255, 255, 0);
            lampIsClosed = false;
        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            lampIsClosed = true;
        }
    }

}
