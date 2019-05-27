using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed;

    // Use this for initialization
    void Start ()
    {
        moveSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed, Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed, 0f);
    }
}
