using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FightingZombieC : FightingCard
{
    private string m_NAME = "F Zombie C";
    private string m_EFFECT = "When it damages a plant, it freezes it";
    private int m_MANA_COST = 2;
    private int m_COUNTER_MAX_VALUE = 6;
    [HideInInspector] public int POWER = 2;
    [HideInInspector] public int DEFENSE = 2;


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
        Type = CardType.Zombie;
        Subtype = CardSubtype.Fighting;
        Power.text = POWER.ToString();
        Defense.text = DEFENSE.ToString();
    }
    public override void ShowInfo()
    {
        UIElements.Instance.CardInfo.Power.text = "Power: " + Power.text;
        UIElements.Instance.CardInfo.Defense.text = "Defense: " + Defense.text;
        base.ShowInfo();
    }
    public override void HideInfo()
    {
        UIElements.Instance.CardInfo.Power.text = "";
        UIElements.Instance.CardInfo.Defense.text = "";
        base.HideInfo();
    }
}
