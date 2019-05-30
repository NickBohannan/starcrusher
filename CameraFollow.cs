﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float scrollSpeedModifier = 3f;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * scrollSpeedModifier);
    }
}
