using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickA : BaseCard
{
    private string m_NAME = "The Big Freeze";
    private string m_EFFECT = "freeze a zombie, draw a card";
    private int m_MANA_COST = 1;
    private int m_COUNTER_MAX_VALUE = 2;

    private void Awake()
    {
        InitializeCard();
    }

    public override void InitializeCard()
    {
        Name.text = m_NAME;
        Effect.text = m_EFFECT;
        ManaCost.text = m_MANA_COST.ToString();
        Counter = m_COUNTER_MAX_VALUE;
        Type = CardType.Plant;
    }
}


