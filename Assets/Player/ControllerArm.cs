using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerArm : MonoBehaviour
{
    [SerializeField] private Transform aim;
    [SerializeField] private Transform helpController;
    [SerializeField] int sensetiv = 10;

    private Rigidbody rigidbody;
    

    void Start()
    {  
        rigidbody = GetComponent<Rigidbody>();
        //MoveArm = GetComponent<AimMove>();
        //aim = GetComponent<Transform>();
       // transform.position = helpController.transform.position;
    }

    void Update()
    {
        //aim.transform.position = new Vector3(aim.position.x, aim.position.y);
        //Vector2 ControllerArms = MoveArm.GetDirection();
        // gameObject.transform.rotation = Quaternion.Euler(aim.localEulerAngles); 
                        
        gameObject.transform.LookAt(helpController, transform.localPosition);
        //GetComponent<Rigidbody>().isKinematic = false;

    }
}
