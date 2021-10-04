using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aim : MonoBehaviour
{
    //Rigidbody rigidbody;
    public float Speed = 20; 
    public AimMove touchPad;

    void Start()
    {
       
    }
    
    void  Update()
    {
        Vector2 direction = touchPad.GetDirection();
         
        if(Input.touchCount > 0)
        {
            transform.Translate(direction * Speed * Time.deltaTime);
        }
    }
}
