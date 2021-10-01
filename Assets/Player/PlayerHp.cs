using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour, IHp
{
    int _IsHp = 100;
    int curyHp;
    public void DicreaseHp()
    {
        curyHp -= 25;
    }
    public void CheckHp()
    {
        if(curyHp < 0)
        {
            Debug.Log("you dead");
        }
    }
    private void Start()
    {
        curyHp = _IsHp;

    }
    // Update is called once per frame

}
