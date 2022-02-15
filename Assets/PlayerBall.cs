using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float JumpPower;
    Rigidbody rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();        
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
            rigid.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);

        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log(Camera.main.pixelWidth/2-Input.mousePosition.x);

            if(Camera.main.pixelWidth/2-Input.mousePosition.x > 0)
                rigid.AddForce(new Vector3(10, JumpPower, 0), ForceMode.Impulse);
            else
                rigid.AddForce(new Vector3(-10, JumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }
}
