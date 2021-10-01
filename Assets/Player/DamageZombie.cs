using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZombie : HpZombie
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            CheckHp();
            DicreaseHp();
            Debug.Log("ok");
        }
    }
}
