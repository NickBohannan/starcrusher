using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantDeath : MonoBehaviour {

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Laser(Clone)")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
