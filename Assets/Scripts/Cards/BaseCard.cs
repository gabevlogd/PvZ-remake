using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class BaseCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject PrefabForBattlefield;
    public Text Name;
    public Text Effect;
    public Text ManaCost;
    [HideInInspector] public int Counter;
    [HideInInspector] public CardType Type;


    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        ShowInfo();
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        HideInfo();
    }

    public abstract void InitializeCard();
    public virtual void ShowInfo() { }
    public virtual void HideInfo() { }
}

public enum CardType
{
    Zombie,
    Plant
}


