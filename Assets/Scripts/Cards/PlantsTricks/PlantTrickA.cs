using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlantTrickA : BaseCard
{
    private string m_NAME = "The Big Freeze";
    private string m_EFFECT = "freeze a zombie, draw a card";
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


