using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AimMove aimRotation;
    Transform RotationGun;
    void Start()
    {
        RotationGun = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      //  RotationGun.rotation = Quaternion.Slerp();
        
      
    }
}
