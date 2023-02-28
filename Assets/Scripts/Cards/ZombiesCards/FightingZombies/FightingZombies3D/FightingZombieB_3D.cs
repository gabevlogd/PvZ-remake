using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingZombieB_3D : MonoBehaviour
{
    public FightingZombieB RepresentedCard;
    public TextMesh Power;
    public TextMesh Defense;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.ZombiesDeck)
        {
            if (card.TryGetComponent(out FightingZombieB targetCard))
            {
                //Debug.Log(targetCard.ManaCost.text);
                RepresentedCard = targetCard;
            }
        }
        UIElements.Instance.PlayerTwo.ManaBase -= Int32.Parse(RepresentedCard.ManaCost.text);
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
