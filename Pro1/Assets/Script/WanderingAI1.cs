using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI1 : MonoBehaviour {
    public Transform target;
    public float moveSpeed = 5.0f;
    public float obstacleRange = 4.0f;
    public float rotationSpeed = 5.0f;
    public float distance;
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

        
        distance = Vector3.Distance(myTransform.position, target.position);
        if (distance <= 10)
        {
            //  在敌人和玩家之间画一条线
            Debug.DrawLine(target.position, myTransform.position, Color.red);
            //  看着目标
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            //  移向目标
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

        }
        else {
            myTransform.Translate(0, 0, moveSpeed * Time.deltaTime);

            Ray ray = new Ray(myTransform.position, myTransform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit)) {
                if (hit.distance < obstacleRange) {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }

    }

}
