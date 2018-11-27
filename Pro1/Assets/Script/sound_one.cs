using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_one : MonoBehaviour {

    public AudioSource audio;
	// Use this for initialization
	void Start () {
        //audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (audio != null) {
            if (Input.GetKey("up"))
            {
                audio.Play();
            }
        }
	}
    
}
