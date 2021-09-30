using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    public GameObject BulletMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove.transform.position = transform.position;
    }
    public void InstansionBulllet()
    {
        Instantiate(BulletMove);
    }
}
