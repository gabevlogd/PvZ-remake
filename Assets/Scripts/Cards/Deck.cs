using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private Counters counter;

    public Deck()
    {
        counter.TrickA = 0;
        counter.TrickB = 0;
        counter.TrickC = 0;
        counter.TrickD = 0;
        counter.TrickE = 0;
        counter.CreatureA = 0;
        counter.CreatureB = 0;
        counter.CreatureC = 0;
        counter.CreatureD = 0;
        counter.CreatureE = 0;
    }
    public void DrawHand()
    {
        for(int i = 0; i < 4; i++)
        {

        }
    }
    public void Draw()
    {

    }
}

public struct Counters
{
    public int TrickA;
    public int TrickB;
    public int TrickC;
    public int TrickD;
    public int TrickE;
    public int CreatureA;
    public int CreatureB;
    public int CreatureC;
    public int CreatureD;
    public int CreatureE;
}
