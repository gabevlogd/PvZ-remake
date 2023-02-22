using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickD : BaseCard
{
    private string m_NAME = "Fertilizer";
    private string m_EFFECT = "A plant gets +3/+3";
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
