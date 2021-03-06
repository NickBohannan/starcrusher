﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyFire : MonoBehaviour {

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    void Start()
    {

    }

    void Update()
    {
        if (Random.Range(0f, 100f) < 5)
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            Temporary_Bullet_Handler.AddComponent<InstantDeath>();

            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_RigidBody.AddForce(transform.forward * -Bullet_Forward_Force);

            Destroy(Temporary_Bullet_Handler, 2.0f);
        }
    }


}
