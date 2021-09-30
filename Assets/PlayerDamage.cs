using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : PlayerHp
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            DicreaseHp();
            CheckHp();
            Debug.Log("error");
        }

    }
    
    private void Start()
    {
        Debug.Log("start");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
