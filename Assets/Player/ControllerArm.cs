using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerArm : MonoBehaviour
{
    [SerializeField] public Transform aim;
    private Vector3 look;
    private int sensetiv = 10;
    Rigidbody rigidbody;
    //private AimMove MoveArm;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
      //  MoveArm = GetComponent<AimMove>();      
    }

    void Update()
    {
        //Vector2 ControllerArms = MoveArm.GetDirection();
        look = Vector3.Lerp(look, aim.transform.position, sensetiv * Time.deltaTime);
        gameObject.transform.LookAt(aim.transform);
        
        
    }
}
