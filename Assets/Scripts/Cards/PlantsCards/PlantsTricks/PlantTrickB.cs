using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickB : BaseCard
{
    private string m_NAME = "Precise Explosion";
    private string m_EFFECT = "Attack the middle row for 5 damage";
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
