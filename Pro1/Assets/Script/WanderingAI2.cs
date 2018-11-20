using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI2 : MonoBehaviour {

    public Transform target;
    public int moveSpeed = 5;
    public int rotationSpeed = 5;
    private Transform myTransform;
    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player"); 
        target = go.transform;

    }

    void Update()
    {
        
        //  在敌人和玩家之间画一条线
        Debug.DrawLine(target.position, myTransform.position, Color.red);
        //  看着目标
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

        //  移向目标
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

    }

}
