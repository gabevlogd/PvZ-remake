using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour
{
    public ZoneType zoneType;
    public bool Selected;

    private void OnMouseEnter()
    {
        //print("enter");
        Selected = true;
    }

    private void OnMouseExit()
    {
        //print("exit");
        Selected = false;
    }

    private void OnMouseUp()
    {
        //print("Drop");
    }

}

public enum ZoneType
{
    Battlefield,
    Hand
}

//public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
//{
//    public ZoneType zoneType;
//    public void OnPointerEnter(PointerEventData eventData)
//    {
//        Debug.Log("OnPointerEnter");
//    }

//    public void OnPointerExit(PointerEventData eventData)
//    {
//        Debug.Log("OnPointerExit");
//    }

//    public void OnDrop(PointerEventData eventData)
//    {
//        Debug.Log("OnDrop");
//        //Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();


//    }

//}
