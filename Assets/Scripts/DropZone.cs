using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public ZoneType zoneType;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if(zoneType == ZoneType.Battlefield)
        {
            
        }
        draggable.ParentToReturnTo = transform;

    }

}

public enum ZoneType
{
    Battlefield,
    Hand
}
