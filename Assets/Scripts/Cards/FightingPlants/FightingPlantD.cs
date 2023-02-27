using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingPlantD : BaseCard
{
    private string m_NAME = "Burning Log";
    private string m_EFFECT = "The seeds shooter behind him gets +2/+0";
    private int m_MANA_COST = 1;
    private int m_COUNTER_MAX_VALUE = 6;
    [HideInInspector] public int POWER = 0;
    [HideInInspector] public int DEFENSE = 3;

    public Text Power;
    public Text Defense;

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
        Power.text = POWER.ToString();
        Defense.text = DEFENSE.ToString();
    }
}
