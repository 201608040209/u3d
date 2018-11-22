using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {

    private int _health;
	// Use this for initialization
	void Start () {
        _health = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReactToHit()
    {
        StartCoroutine(Die());
    }
    private IEnumerator Die() {
        //Debug.Log("Health:" + _health);
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(0.1f);
        _health--;
        if (_health == 0) {
            Destroy(this.gameObject);
        }      
    }
}
