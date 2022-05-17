using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))

            
            
                GetComponent<Renderer>().material.color = new Color(255, 255, 0);
                
            
    }

}
