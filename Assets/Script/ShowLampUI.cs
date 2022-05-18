using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLampUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UIObject;
    void Start()
    {
        UIObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);
          

        }

    }
    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            UIObject.SetActive(false);
        }
    }

}
