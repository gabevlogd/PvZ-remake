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
        CanBeDrag = true;
        m_canvasGroup = GetComponent<CanvasGroup>();
        DropZones = new DropZone[5];
    }

    private void Start()
    {
        if (GetComponent<BaseCard>().Type == CardType.Plant)
        {
            for (int i = 0; i < 5; i++)
            {
                DropZones[i] = GameObject.Find("P1DZ" + i.ToString()).GetComponent<DropZone>();
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                DropZones[i] = GameObject.Find("P2DZ" + i.ToString()).GetComponent<DropZone>();
            }
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
