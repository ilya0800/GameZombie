using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowAim : MonoBehaviour
{
    public GameObject AimRotation;
    AimMove aimMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.rotation = new Quaternion.
      //  transform.rotation = Quaternion.Euler(AimRotation.transform.rotation.eulerAngles.x, AimRotation.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
