using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOld : MonoBehaviour
{
    //public Player Player;
    public int[] Counters;

    private void Start()
    {
        InitializeCounters();
        DrawN(4);
    }

    public void DrawN(int n)
    {
        for (int i = 0; i < n; i++) Draw();
    }

    public void Draw()
    {
        //int index = Random.Range(0, 10);
        //if(Player.squad == Squad.Zombies)
        //{
        //    while (CardsInventory.Instance.ZombiesCards[index].Counter > Counters[index]) index = Random.Range(0, 10);
        //    Card cardDrawn = new Card(Player.squad, (CardType)index);
        //    Player.Hand.Add(cardDrawn);
        //}
        //else
        //{
        //    while (CardsInventory.Instance.PlantsCards[index].Counter > Counters[index]) index = Random.Range(0, 10);
        //    Card cardDrawn = new Card(Player.squad, (CardType)index);
        //    Player.Hand.Add(cardDrawn);
        //}
    }

    private void InitializeCounters()
    {
        Counters = new int[10];
        for(int i = 0; i < Counters.Length; i++)
        {
            if (i < 5) Counters[i] = 2;
            else Counters[i] = 6;
        }
    }
}

//public struct Counters
//{
//    public int TrickA;
//    public int TrickB;
//    public int TrickC;
//    public int TrickD;
//    public int TrickE;
//    public int CreatureA;
//    public int CreatureB;
//    public int CreatureC;
//    public int CreatureD;
//    public int CreatureE;
//}
//counter.TrickA = 0;
//counter.TrickB = 0;
//counter.TrickC = 0;
//counter.TrickD = 0;
//counter.TrickE = 0;
//counter.CreatureA = 0;
//counter.CreatureB = 0;
//counter.CreatureC = 0;
//counter.CreatureD = 0;
//counter.CreatureE = 0;
