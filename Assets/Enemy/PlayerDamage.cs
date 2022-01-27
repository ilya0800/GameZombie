using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    HpZombie hpZombie = new HpZombie();
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            hpZombie.DicreaseHp();
            hpZombie.CheckHp();
            Destroy(gameObject);
          
        }
    }
    
}
