using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
