using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testArmMove : MonoBehaviour
{
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    //    characterController.Move();
    }
}
