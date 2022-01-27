using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveAim : MonoBehaviour
{
    public Vector3 MoveAim;
    MouseMoveArms mouseMove = new MouseMoveArms();

    [SerializeField] float speedMoveAim = 1;

    void Start()
    {
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //MoveAim = new Vector3(Input.GetAxisRaw("Mouse X") * speedMoveAim, Input.GetAxisRaw("Mouse Y") * speedMoveAim, 0);
            //transform.Translate(MoveAim * speedMoveAim * Time.deltaTime);
            //transform.position = new Vector2(mouseMove.vector.x, mouseMove.vector.y); 
        }
    }
}
