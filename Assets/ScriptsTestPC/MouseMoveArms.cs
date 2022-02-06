using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseMoveArms : MonoBehaviour, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    Vector2 Direction = Vector2.zero;
    [SerializeReference]float speed;
    Vector2 DirectionEnd;
    Vector2 DirectionCyrr = Vector2.zero;
    PointerEventData DirectionStart;
    bool IsMove => DirectionStart != null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        DirectionStart = eventData;

        //DirectionStart = eventData.position;
        //DirectionStart = DirectionEnd;
        //Direction = DirectionEnd;
    }
    public void OnDrag(PointerEventData eventData)
    {
        DirectionCyrr = eventData.position;
        DirectionEnd = DirectionStart.position - DirectionCyrr;
        
        Direction = DirectionEnd;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        DirectionStart = null;

        //DirectionEnd = Direction;
    }

    public Vector3 GetDirection()
    {
        return Direction;
    }
}
