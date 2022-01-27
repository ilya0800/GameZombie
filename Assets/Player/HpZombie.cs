using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpZombie : MonoBehaviour, IHp
{
    private float hp = 50;
    private float curryHp;
    
    public void CheckHp()
    {
        if(curryHp < 0)
        {
           Debug.Log("ZombieDead");
            //GameObject.FindGameObjectWithTag("Enemy").SetActive(false);         
                         

        }
    }

    public void DicreaseHp()
    {
       
        curryHp -= 25;
    }

    void Start()
    {
        curryHp = hp;  
    }

}
