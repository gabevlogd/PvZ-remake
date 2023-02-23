using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingPlantB : BaseCard
{
    private string m_NAME = "Seeds Shooter";
    private string m_EFFECT = "Double Attack";
    private int m_MANA_COST = 3;
    private int m_COUNTER_MAX_VALUE = 6;
    [HideInInspector] public int POWER = 2;
    [HideInInspector] public int DEFENSE = 2;

    public Text Power;
    public Text Defense;

    private void Awake()
    {
        initializeCard();
    }

    private void initializeCard()
    {
        Name.text = m_NAME;
        Effect.text = m_EFFECT;
        ManaCost.text = m_MANA_COST.ToString();
        Counter = m_COUNTER_MAX_VALUE;
        Power.text = POWER.ToString();
        Defense.text = DEFENSE.ToString();
    }
}
