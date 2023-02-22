using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickC : BaseCard
{
    private string m_NAME = "Expand";
    private string m_EFFECT = "A plant gets +2/+2";
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
