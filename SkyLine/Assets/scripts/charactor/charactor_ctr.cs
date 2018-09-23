using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactor_ctr : MonoBehaviour {

    public float move_speed=3;//角色移动速度
    public float rota_speed=3;//角色旋转速度
    private CharacterController characterController;//角色胶囊
    private Transform m_tran;//角色位置信息
    void Start()
    {
        m_tran = this.transform;
        characterController = this.GetComponent<CharacterController>();
    }
    private void Update()
    {
        m_tran.Rotate(0, Input.GetAxis("Horizontal") * rota_speed, 0);//旋转
        Vector3 forward = transform.TransformDirection(Vector3.forward);  
        float curSpeed = move_speed * Input.GetAxis("Vertical");//移动
        characterController.SimpleMove(forward * curSpeed);
    }


}
