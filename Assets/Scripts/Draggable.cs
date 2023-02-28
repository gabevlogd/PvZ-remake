using System;
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
        FindDropZones();
    }

    private void Update()
    {
        SetDraggability();
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
                    if (eventData.pointerDrag.GetComponent<BaseCard>().Subtype == CardSubtype.Fighting)
                    {
                        dropZone.Taken = true;
                        dropZone.CardOnZone = eventData.pointerDrag.GetComponent<BaseCard>();
                        eventData.pointerDrag.SetActive(false);
                    }
                    else Destroy(eventData.pointerDrag);
                    return;
                }
            }
            transform.SetParent(ParentToReturnTo);
            m_canvasGroup.blocksRaycasts = true;
        }
        
    }

    /// <summary>
    /// Determines whether the gameobject can be dragged
    /// </summary>
    public void SetDraggability()
    {
        if (StateManager.Instance.CurrentState.StateType == StateType.PlantsTurn && Int32.Parse(GetComponent<BaseCard>().ManaCost.text) <= UIElements.Instance.PlayerOne.ManaBase) CanBeDrag = true;
        else if (StateManager.Instance.CurrentState.StateType == StateType.ZombiesTurn && Int32.Parse(GetComponent<BaseCard>().ManaCost.text) <= UIElements.Instance.PlayerTwo.ManaBase) CanBeDrag = true;
        else if (StateManager.Instance.CurrentState.StateType == StateType.ZombiesTricks && GetComponent<BaseCard>().Subtype == CardSubtype.Trick && Int32.Parse(GetComponent<BaseCard>().ManaCost.text) <= UIElements.Instance.PlayerTwo.ManaBase) CanBeDrag = true;
        else if (CanBeDrag) CanBeDrag = false;
    }

    /// <summary>
    /// Finds areas where the gameobject can be placed
    /// </summary>
    public void FindDropZones()
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
}
