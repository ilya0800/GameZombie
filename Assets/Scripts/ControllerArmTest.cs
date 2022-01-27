using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerArmTest : MonoBehaviour
{
    // Start is called before the first frame update
    public MouseMoveArms moveArms;
    [SerializeField] float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = moveArms.GetDirection();
        if (Input.GetMouseButton(0))
        {
            transform.localEulerAngles = new Vector3(vector3.x * speed, vector3.y * speed, vector3.z * speed);      
        }
    }
}
