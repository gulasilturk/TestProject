using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public static LampController lampcontroller;

    private bool lampIsClosed = true;

    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
          
                OpenLamp();
                //GetComponent<Renderer>().material.color = new Color(255, 255, 0);
            
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
