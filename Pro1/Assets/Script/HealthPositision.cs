using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPositision : MonoBehaviour {


    /*public float xOffset;
    public float yOffset;
    public Transform recTransform;*/

    public Transform m_Name;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector2 player2DPosition = Camera.main.WorldToScreenPoint(transform.position);
        recTransform.position = player2DPosition + new Vector2(xOffset, yOffset);

        //血条超出屏幕就不显示
        if (player2DPosition.x > Screen.width || player2DPosition.x < 0 || player2DPosition.y > Screen.height || player2DPosition.y < 0)
        {
            recTransform.gameObject.SetActive(false);
        }
        else
        {
            recTransform.gameObject.SetActive(true);
        }*/
        m_Name.transform.LookAt(Camera.main.transform.position);
        m_Name.transform.rotation = Quaternion.Slerp(m_Name.transform.rotation, Quaternion.LookRotation(Camera.main.transform.position - m_Name.transform.position), 10 * Time.deltaTime);


    }

}
