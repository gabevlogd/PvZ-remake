using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickB : BaseCard
{
    private string m_NAME = "Precise Explosion";
    private string m_EFFECT = "Attack the middle row for 5 damage";
    private int m_MANA_COST = 1;

    private void Start()
    {
        initializeCard();
    }

    private void initializeCard()
    {
        Name.text = m_NAME;
        Effect.text = m_EFFECT;
        ManaCost.text = m_MANA_COST.ToString();
    }
}
