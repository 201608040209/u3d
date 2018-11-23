using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour {

    public Transform target;
    public float rotationSpeed = 4.0f;
    public float distance;
	// Use this for initialization
	void Start () {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 10) {
            Debug.DrawLine(target.position, transform.position, Color.red);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
        }
	}
}
