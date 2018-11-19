using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI2 : MonoBehaviour {

    public Transform c;
    public float speed = 3.0f;
    private Vector3 d;
    private bool challanged = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (challanged) {
            d = c.transform.position - transform.position;
            d = d.normalized;
            transform.Translate(d*speed,Space.World);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WarTank")) {
            challanged = true;
        }
    }
}
