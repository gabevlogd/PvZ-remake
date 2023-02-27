using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : Object
{
    public Trick Data;
    public CardType cardType;

    public Card(Squad squad, CardType type)
    {
        //print("enter");
        cardType = type;
        //InitializeCard(squad);
    }
    //public virtual void InitializeCard(Squad squad)
    //{
    //    if(squad == Squad.Zombies)
    //    {
    //        Data = CardsInventory.Instance.ZombiesCards[(int)cardType];
    //        Data.Counter++;
    //    }
    //    else
    //    {
    //        Data = CardsInventory.Instance.PlantsCards[(int)cardType];
    //        Data.Counter++;

    //    }
    //}

    

}

//public enum CardType
//{
//    TrickA,
//    TrickB,
//    TrickC,
//    TrickD,
//    TrickE,
//    CreatureA,
//    CreatureB,
//    CreatureC,
//    CreatureD,
//    CreatureE
//}

