using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aim : MonoBehaviour

{
    Rigidbody rigidbody;
    public float Speed = 10; 
    public AimMove touchPad;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void  Update()
    {
        
        Vector2 direction = touchPad.GetDirection();
        rigidbody.velocity = new Vector3(direction.x, direction.y) * Speed;  
    
    }
}
