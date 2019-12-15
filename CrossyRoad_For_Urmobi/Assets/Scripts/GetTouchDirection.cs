using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GetTouchDirection : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Movement myMovement;
    Vector2 delta; 

    public void OnDrag(PointerEventData eventData)
    {       
        delta = eventData.delta;
        myMovement.IsDragActive = true;
    }
 
    public void OnEndDrag(PointerEventData eventData)
    {
        myMovement.Move(delta);
    }
}
