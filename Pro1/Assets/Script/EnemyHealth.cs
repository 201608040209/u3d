using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    
    private int health;

	// Use this for initialization
	void Start () {
        health = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Hurt(int damage) {
        health -= damage;
        if (health == 0) {
            Destroy(this.gameObject);
        }
    }
}
