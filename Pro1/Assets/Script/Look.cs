using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour {

    public float rotation;

    //炮塔水平旋转
	// Use this for initialization
	void Start () {
        //检查组件是否存在
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Input.GetAxis("TankP1") *rotation*Time.deltaTime, 0);
	}
}
