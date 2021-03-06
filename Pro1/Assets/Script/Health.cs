﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Slider HPSlider;
    public Text HPText;
    public float HP;
    public GameObject explosion;
	// Use this for initialization
	void Start () {
        HP = HPSlider.value = HPSlider.maxValue;
        HPText.text = HP + "/" + HPSlider.maxValue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void HurtHP(int damage) {

        HP -= damage;
        HPSlider.value = HP;
        HPText.text = HP + "/" + HPSlider.maxValue;
        if (HP == 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
