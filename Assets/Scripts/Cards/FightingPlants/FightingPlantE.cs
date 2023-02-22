using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingPlantE : BaseCard
{
    private string m_NAME = "Aviator Seeds Shooter";
    private string m_EFFECT = "when enters the battlefield on elevated surfaces: it gets +2/+2";
    private int m_MANA_COST = 4;
    [HideInInspector] public int POWER = 3;
    [HideInInspector] public int DEFENSE = 2;

    public Text Power;
    public Text Defense;

    private void Start()
    {
        initializeCard();
    }

    private void initializeCard()
    {
        Name.text = m_NAME;
        Effect.text = m_EFFECT;
        ManaCost.text = m_MANA_COST.ToString();
        Power.text = POWER.ToString();
        Defense.text = DEFENSE.ToString();
    }
}
