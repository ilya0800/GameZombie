using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerArmTest : MonoBehaviour
{
    public MouseMoveArms moveArms;
    TestMoveArm testMove;
    [SerializeField] float speed;
    Vector3 Euler;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 vector3 = moveArms.GetDirection();
            transform.localEulerAngles = vector3 * speed;
            //transform.Translate(vector3);
        }
    }
}
