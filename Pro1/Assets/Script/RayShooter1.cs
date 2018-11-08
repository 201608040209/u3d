using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter1 : MonoBehaviour {

    private Camera camera;
	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 point = new Vector3(camera.pixelWidth/2,camera.pixelHeight/2,0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                Debug.Log("Hit " + hit.point);
            }
        }
	}
}
