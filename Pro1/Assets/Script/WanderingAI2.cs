using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI2 : MonoBehaviour {
    public float distanceToMe;           //智能体到目标的距离
    public GameObject me;                //目标角色
    public float isSeekDistance = 3.0f;  //可靠近范围
    public int state;                     //智能体状态

    void Start()
    {
        me = GameObject.FindWithTag("WarTank");
    }
    void Update()
    {
        switch (state)
        {
            case 0:
                Idle();   //空闲，四处游荡
                break;
            case 1:
                Seek();   //向目标靠近
                break;
        }
    }
    //智能体空闲函数
    void Idle()
    {
        //获取两者间的距离
        distanceToMe = Vector3.Distance(me.transform.position, this.transform.position);
        if (distanceToMe > isSeekDistance) //大于可靠近范围，进入空闲状态
        {
            state = 0;
            if (Random.value > 0.5)             //通过随机值，使其随机左右移动
            {
                this.transform.Rotate(Vector3.up * 5);
            }
            else
            {
                transform.Rotate(Vector3.up * -5.0f);
            }
            this.transform.Translate(Vector3.forward * 0.1f);
        }
        else
        {
            state = 1;
        }
    }
    //智能体靠近函数
    void Seek()
    {
        distanceToMe = Vector3.Distance(me.transform.position, this.transform.position);
        if (distanceToMe < isSeekDistance)
        {
            this.transform.LookAt(me.transform);               //该方法使智能体总是面对目标
            this.transform.Translate(Vector3.forward * 0.1f);  //向目标前进，即靠近（Vector3.back 后退，则逃避）
        }
        else
        {
            state = 0;
        }
    }

}




