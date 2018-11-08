using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {
    public float MoveSpeed;
    public float RotateSpeed;
    private Rigidbody rb;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("VerticalPlayer1");
        rb.velocity = transform.forward * v * MoveSpeed;
        float h = Input.GetAxis("HorizontalPlayer1");
        rb.angularVelocity = transform.up * h * RotateSpeed;

    }
}
