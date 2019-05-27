using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMovement : MonoBehaviour {

    public float lateralAmplitudeModifier;
    public float lateralVelocityModifier;
    public float longitudinalVelocityModifier;

    public int stepCount = 0;

    private Rigidbody rb;

	void Start () {

        rb = gameObject.GetComponent<Rigidbody>();

        lateralAmplitudeModifier = 100f;
        lateralVelocityModifier = 4f;
        longitudinalVelocityModifier = 5f;

        stepCount = 0;

    }
	
	void Update () {

        transform.Translate(Vector3.back * Time.deltaTime * longitudinalVelocityModifier);

        if (stepCount > lateralAmplitudeModifier * 1.5f)
        {
            stepCount = 0;
        }

        stepCount++;

        if (stepCount < lateralAmplitudeModifier / 1.5f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * lateralVelocityModifier);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * lateralVelocityModifier);
        }

    }

}
