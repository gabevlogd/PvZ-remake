using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public DropZone[] DropZonesP1;
    public DropZone[] DropZonesP2;

    public static bool FightEnded;



    private void Awake()
    {
        FightEnded = false;
        InitializeDropZones();
        Fight();
        FightEnded = true;
    }


    private void InitializeDropZones()
    {
        DropZonesP1 = new DropZone[5];
        DropZonesP2 = new DropZone[5];
        for (int i = 0; i < 5; i++)
        {
            DropZonesP1[i] = GameObject.Find("P1DZ" + i.ToString()).GetComponent<DropZone>();
        }

        for (int i = 0; i < 5; i++)
        {
            DropZonesP2[i] = GameObject.Find("P2DZ" + i.ToString()).GetComponent<DropZone>();
        }
    }

    private void Fight()
    {

        for(int i = 0; i < DropZonesP1.Length; i++)
        {
            //Debug.Log(dropZone.CardOnZone?.name);
            FightingCard cardP1 = null;
            FightingCard cardP2 = null;
            if (DropZonesP1[i].CardOnZone != null) cardP1 = DropZonesP1[i].CardOnZone;
            if (DropZonesP2[i].CardOnZone != null) cardP2 = DropZonesP2[i].CardOnZone;

            if (cardP1 == null && cardP2 == null) continue;
            else if (cardP1 != null && cardP2 == null)
            {
                UIElements.Instance.PlayerTwo.LifePoint -= Int32.Parse(cardP1.Power.text);
                if(UIElements.Instance.PlayerTwo.LifePoint <= 0)
                {
                    StateManager.Instance.ChangeState(StateType.EndGame);
                    return;
                }
            }
            else if (cardP1 == null && cardP2 != null)
            {
                UIElements.Instance.PlayerOne.LifePoint -= Int32.Parse(cardP2.Power.text);
                if (UIElements.Instance.PlayerOne.LifePoint <= 0)
                {
                    StateManager.Instance.ChangeState(StateType.EndGame);
                    return;
                }
            }
            else if (cardP1 != null && cardP2 != null)
            {
                cardP1.Defense.text = (Int32.Parse(cardP1.Defense.text) - Int32.Parse(cardP2.Power.text)).ToString();
                cardP2.Defense.text = (Int32.Parse(cardP2.Defense.text) - Int32.Parse(cardP1.Power.text)).ToString();
            }

            if(cardP1 != null && Int32.Parse(cardP1.Defense.text) <= 0)
            {
                DropZonesP1[i].Taken = false;
                Destroy(cardP1);
            }
            if (cardP2 != null && Int32.Parse(cardP2.Defense.text) <= 0)
            {
                DropZonesP2[i].Taken = false;
                Destroy(cardP2);
            }
        }
    }

}
