using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {

    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private Rigidbody rb;
    public GameObject fireball;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.7f, out hit)) {
            if (fireball == null) {
                fireball = Instantiate(fireball) as GameObject;
                fireball.transform.position = transform.TransformPoint(Vector3.forward * 10f);
                fireball.transform.rotation = transform.rotation;
            }
            else if (hit.distance < obstacleRange) {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }
}
