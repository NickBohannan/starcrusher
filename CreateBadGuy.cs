using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBadGuy : MonoBehaviour {

    public GameObject Bad_Guy;
    public GameObject Bad_Bullet;

    public float spawnRateModifier = 8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range(0f, 1000f) < spawnRateModifier)
        {
            GameObject Bad_Guy_Handler;
            Bad_Guy_Handler = Instantiate(Bad_Guy, gameObject.transform.position, gameObject.transform.rotation);
            Physics.IgnoreCollision(Bad_Guy_Handler.GetComponent<Collider>(), Bad_Bullet.GetComponent<Collider>());

            Destroy(Bad_Guy_Handler, 15f);
        }
	}
}
