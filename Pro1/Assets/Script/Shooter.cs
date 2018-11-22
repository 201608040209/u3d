using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    private float speed = 10.0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        EnemyHealth player = other.GetComponent<EnemyHealth>();
        if (player != null) {
            player.Hurt(1);
        }
        Destroy(this.gameObject);
    }

}
