using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallEnemy : MonoBehaviour {

    [SerializeField] private GameObject fireballPrefab;
    //public GameObject fireball;
    public float firetime = 0.0f;
    public float distance = 0.0f;
    public Transform target;
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 10.0f) {
            if (firetime <= 0)
            {
                GameObject fireball = Instantiate(fireballPrefab, transform.position, transform.rotation) as GameObject;
                firetime = 1.0f;
            }
            else
            {
                firetime = firetime - Time.deltaTime;
            }
        }
        

    }
}
