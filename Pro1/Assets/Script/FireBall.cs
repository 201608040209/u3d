using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {
    [SerializeField] private GameObject fireballPrefab;
    //public GameObject fireball;
    public float firetime = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (firetime <= 0)
        {
            if (Input.GetKey("up"))
            {

                GameObject fireball = Instantiate(fireballPrefab,transform.position,transform.rotation) as GameObject;
                
                //fireball.transform.position = gameObject.transform.TransformPoint(Vector3.forward * 1.5f);
                //fireball.transform.rotation = gameObject.transform.rotation;
                //Destroy(fireball, 5f);
                firetime = 1.0f;
            }
        }
        else
        {
            firetime = firetime - Time.deltaTime;
        }
        
	}
    


}
