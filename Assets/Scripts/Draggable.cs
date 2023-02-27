using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform ParentToReturnTo;
    public DropZone[] DropZones;
    [HideInInspector] public bool CanBeDrag;
    private CanvasGroup m_canvasGroup;

    private void Awake()
    {
        CanBeDrag = false;
        m_canvasGroup = GetComponent<CanvasGroup>();
        DropZones = new DropZone[5];
        for(int i = 0; i < 5; i++)
        {
            DropZones[i] = GameObject.Find("DZ" + i.ToString()).GetComponent<DropZone>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        if (CanBeDrag)
        {
            m_canvasGroup.blocksRaycasts = false;
            ParentToReturnTo = transform.parent;
            transform.SetParent(transform.parent.parent);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        if (CanBeDrag) transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        if (CanBeDrag)
        {
            foreach (DropZone dropZone in DropZones)
            {
                if (dropZone.Selected && !dropZone.Taken)
                {
                    //Debug.Log(dropZone.name);
                    GameObject prefabForBattlefield = eventData.pointerDrag.GetComponent<BaseCard>().PrefabForBattlefield;
                    Instantiate(prefabForBattlefield, dropZone.transform.position, prefabForBattlefield.transform.rotation);
                    Destroy(eventData.pointerDrag);
                    dropZone.Taken = true;
                    return;
                }
            }
            transform.SetParent(ParentToReturnTo);
            m_canvasGroup.blocksRaycasts = true;
        }
        
    }
}
