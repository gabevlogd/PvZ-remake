using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrickD : BaseCard
{
    private string m_NAME = "T Zombie D";
    private string m_EFFECT = "A zombie gets +3/+3";
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
        Type = CardType.Zombie;
        Subtype = CardSubtype.Trick;
    }
}
