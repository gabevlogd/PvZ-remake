using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingPlantA : BaseCard
{
    private string m_NAME = "Boletus";
    private string m_EFFECT = "When enters the battlefield: another plant gets +2/+2";
    private int m_MANA_COST = 3;
    [HideInInspector] public int POWER = 2;
    [HideInInspector] public int DEFENSE = 1;

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

