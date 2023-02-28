using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingPlantE_3D : MonoBehaviour
{
    public FightingPlantE RepresentedCard;
    public TextMesh Power;
    public TextMesh Defense;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.PlantsDeck)
        {
            if (card.TryGetComponent(out FightingPlantE targetCard))
            {
                //Debug.Log(targetCard.ManaCost.text);
                RepresentedCard = targetCard;
            }
        }
        UIElements.Instance.PlayerOne.ManaBase -= Int32.Parse(RepresentedCard.ManaCost.text);
        Power.text = RepresentedCard.POWER.ToString();
        Defense.text = RepresentedCard.DEFENSE.ToString();
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
