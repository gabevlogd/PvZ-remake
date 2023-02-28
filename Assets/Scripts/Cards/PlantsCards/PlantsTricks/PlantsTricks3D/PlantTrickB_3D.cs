using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickB_3D : MonoBehaviour
{
    public PlantTrickB RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.PlantsDeck)
        {
            if (card.TryGetComponent(out PlantTrickB targetCard))
            {
                //Debug.Log(targetCard.ManaCost.text);
                RepresentedCard = targetCard;
            }
        }
        UIElements.Instance.PlayerOne.ManaBase -= Int32.Parse(RepresentedCard.ManaCost.text);
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
