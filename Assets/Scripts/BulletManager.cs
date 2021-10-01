using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    
    [SerializeField]
    private GameObject BulletPrefab;

    void Update()
    {
        //StartCoroutine(OffBullet());

    }

    public void CreateBullet()
    {
        Instantiate(BulletPrefab);
        BulletPrefab.transform.position = transform.position;

    }

    //IEnumerator OffBullet()
    //{
    //    IsMoveBullet = false;
    //    yield return new WaitForSeconds(3);
    //    if (IsMoveBullet)
    //    {
    //        BulletMove.SetActive(false);
    //        //   IsMoveBullet = false;
    //    }

    //}
}
