using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class BulletController : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime);

        }
    }
}