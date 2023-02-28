using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickD : BaseCard
{
    private string m_NAME = "Fertilizer";
    private string m_EFFECT = "A plant gets +3/+3";
    private int m_MANA_COST = 3;
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
        Subtype = CardSubtype.Trick;
    }
}
