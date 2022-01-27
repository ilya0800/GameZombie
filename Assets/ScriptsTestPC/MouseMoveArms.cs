using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseMoveArms : MonoBehaviour, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    Vector3 Direction;
    Vector3 CyrrDorection;
    Vector3 Origin;
    Vector3 RawDirection;
    bool Drag = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Origin = Vector3.zero;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Drag = true;
        CyrrDorection = eventData.position;
        RawDirection = CyrrDorection - Origin;
        Direction = RawDirection.normalized;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Drag = false;
    }
    
    public Vector3 GetDirection()
    {
        return Direction;
    }
}
