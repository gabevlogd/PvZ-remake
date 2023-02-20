using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Deck deck;
    public int LifePoint;
    public int ManaBase;
    public int CardsInHand;
    public Squad squad;

    private void Start()
    {
        deck = new Deck();
        LifePoint = 20;
        ManaBase = 1;
    }
}

public enum Squad
{
    Zombies,
    Plants
}
