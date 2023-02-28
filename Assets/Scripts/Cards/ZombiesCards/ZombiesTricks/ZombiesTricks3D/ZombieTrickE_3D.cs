using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrickE_3D : MonoBehaviour
{
    public ZombieTrickE RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.ZombiesDeck)
        {
            if (card.TryGetComponent(out ZombieTrickE targetCard))
            {
                //Debug.Log(targetCard.ManaCost.text);
                RepresentedCard = targetCard;
            }
        }

        UIElements.Instance.PlayerTwo.ManaBase -= Int32.Parse(RepresentedCard.ManaCost.text);
    }
    private void Start()
    {
        RepresentedCard.ExecuteEffect();
    }
    private void OnMouseEnter()
    {
        RepresentedCard.ShowInfo();
    }

    private void OnMouseExit()
    {
        RepresentedCard.HideInfo();
    }
}
