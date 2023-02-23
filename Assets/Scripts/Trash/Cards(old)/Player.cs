using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> Hand = new List<Card>();
    public Player Instance;
    public Deck deck;
    public Squad squad;
    public int LifePoint;
    public int ManaBase;
    public int CardsInHand;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        LifePoint = 20;
        ManaBase = 1;
    }
}

public enum Squad
{
    Zombies,
    Plants
}
