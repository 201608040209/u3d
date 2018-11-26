using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    private float speed = 30.0f;
    public GameObject explosion;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        CubeHealth player = other.GetComponent<CubeHealth>();
        //EnemyHealth player = other.GetComponent<EnemyHealth>();
        if (player != null) {
            player.HurtHP(1);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

}
