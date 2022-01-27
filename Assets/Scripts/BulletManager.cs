using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    MouseMoveArms moveArms = new MouseMoveArms();
    [SerializeField]
    private GameObject BulletPrefab;
    //[SerializeField]
    //private GameObject BulletStartPositon;

    void Update()
    {
        //StartCoroutine(OffBullet());

    }

    public void CreateBullet()
    {
        //BulletPrefab.transform.localEulerAngles = new Vector3(moveArms.VectorNowPosition.x, moveArms.VectorNowPosition.y);
        Instantiate(BulletPrefab);
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
