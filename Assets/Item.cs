using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up, Space.World); //월드좌표계 회전
    }
}
