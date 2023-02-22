using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickE : BaseCard
{
    private string m_NAME = "Flowering";
    private string m_EFFECT = "Draw two cards";
    private int m_MANA_COST = 3;

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
