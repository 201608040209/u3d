using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_one : MonoBehaviour {

    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Cube") ) {
            audio.Play();
            print("123");
        }
        
    }
}
