using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerArm : MonoBehaviour
{
    [SerializeField] public GameObject aim;
    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(aim.transform.position.x, aim.transform.position.y, transform.position.z);     
    }
}
