using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour
{
    public ZoneType zoneType;
    [HideInInspector] public bool Selected;
    [HideInInspector] public bool Taken;
    /*[HideInInspector]*/ public FightingCard CardOnZone;
    private SpriteRenderer m_selectionFeedback;

    private void Awake()
    {
        m_selectionFeedback = GetComponentInChildren<SpriteRenderer>();
        Taken = false;
    }

    private void OnMouseEnter()
    {
        //print("enter");
        if (Input.GetKey(KeyCode.Mouse0) && !Taken) m_selectionFeedback.color = new Color(m_selectionFeedback.color.r, m_selectionFeedback.color.g, m_selectionFeedback.color.b, 0.3f);
        Selected = true;
    }

    private void OnMouseExit()
    {
        //print("exit");
        m_selectionFeedback.color = new Color(m_selectionFeedback.color.r, m_selectionFeedback.color.g, m_selectionFeedback.color.b, 0f);
        Selected = false;
    }


}

public enum ZoneType
{
    Standard,
    Elevated,
    Water
}


