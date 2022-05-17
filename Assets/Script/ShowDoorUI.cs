using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDoorUI : MonoBehaviour
{
    public GameObject ObjectUI;
    // Start is called before the first frame update
    void Start()
    {
        ObjectUI.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
      if( player.CompareTag("Player")){
            ObjectUI.gameObject.SetActive(true);

        }
    }
}
