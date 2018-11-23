using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    private float speed = 30.0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        Health player = other.GetComponent<Health>();
        //EnemyHealth player = other.GetComponent<EnemyHealth>();
        if (player != null) {
            player.HurtHP(1);
        }
        Destroy(this.gameObject);
    }

}
