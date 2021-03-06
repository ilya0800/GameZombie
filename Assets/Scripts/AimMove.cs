using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AimMove : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
    Vector2 origanal = Vector2.zero;
    Vector2 direcation = Vector2.zero;
    
    
    private void Awake()
    {
        direcation = Vector2.zero;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        origanal = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
       
        Vector2 CurrPosition = eventData.position;
        Vector2 directiomRaw = CurrPosition - origanal;
        direcation = directiomRaw.normalized;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        direcation = Vector2.zero;
    }

    public Vector2 GetDirection()
    {
           return direcation;
    }  
}
 