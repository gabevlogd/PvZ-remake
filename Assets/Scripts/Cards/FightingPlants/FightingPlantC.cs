using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingPlantC : BaseCard
{
    private string m_NAME = "Frost Shooter";
    private string m_EFFECT = "When it damages a zombie, it freezes it";
    private int m_MANA_COST = 2;
    [HideInInspector] public int POWER = 2;
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
