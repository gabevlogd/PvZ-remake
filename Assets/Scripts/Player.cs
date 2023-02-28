using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public Player Instance;
    public GameObject Hand;
    public Squad squad;
    /*[HideInInspector]*/ public int LifePoint;
    /*[HideInInspector]*/ public int ManaBase;

    private void Start()
    {
        InitializePlayer();
    }

    /// <summary>
    /// Initializes the player stats
    /// </summary>
    private void InitializePlayer()
    {
        Instance = this;
        LifePoint = 20;
        ManaBase = 30;
        DrawN(4);
    }

    /// <summary>
    /// Adds a card in the hand of player
    /// </summary>
    public void Draw()
    {
        if(squad == Squad.Plants && Deck.Instance.PlantsCardsDrawn < 40)
        {
            int randomCard;
            do randomCard = Random.Range(0, Deck.Instance.PlantsDeck.Length);
            while (Deck.Instance.PlantsDeck[randomCard].Counter <= 0);
            Deck.Instance.PlantsDeck[randomCard].Counter--;
            Deck.Instance.PlantsCardsDrawn++;
            Instantiate(Deck.Instance.PlantsDeck[randomCard], Hand.transform);
        }
        else if (squad == Squad.Zombies && Deck.Instance.ZombiesCardsDrawn < 40)//REMEMBER: first condition do not needed 
        {
            int randomCard;
            do randomCard = Random.Range(0, Deck.Instance.ZombiesDeck.Length);
            while (Deck.Instance.ZombiesDeck[randomCard].Counter <= 0);
            Deck.Instance.ZombiesDeck[randomCard].Counter--;
            Deck.Instance.ZombiesCardsDrawn++;
            Instantiate(Deck.Instance.ZombiesDeck[randomCard], Hand.transform);
        }
    }

    /// <summary>
    /// Adds N cards in the hand of player
    /// </summary>
    /// <param name="N">Number of cards to add</param>
    public void DrawN(int N)
    {
        for (int i = 0; i < N; i++) Draw();
    }

}

public enum Squad
{
    Zombies,
    Plants
}
