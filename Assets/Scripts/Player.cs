using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public Player Instance;
    public GameObject Hand;
    public Squad squad;
    [HideInInspector] public int LifePoint;
    [HideInInspector] public int ManaBase;

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
        ManaBase = 1;
        //DrawN(4);
        Draw();
    }

    /// <summary>
    /// Adds a card in the hand of player
    /// </summary>
    public void Draw()
    {
        if(squad == Squad.Plants)
        {
            int randomCard = Random.Range(0, Deck.Instance.PlantsDeck.Length);
            while(Deck.Instance.PlantsDeck[randomCard].Counter <= 0) randomCard = Random.Range(0, Deck.Instance.PlantsDeck.Length);
            Deck.Instance.PlantsDeck[randomCard].Counter--;
            Instantiate(Deck.Instance.PlantsDeck[randomCard], Hand.transform);
        }
        else
        {
            int randomCard = Random.Range(0, Deck.Instance.ZombiesDeck.Length);
            while (Deck.Instance.ZombiesDeck[randomCard].Counter <= 0) randomCard = Random.Range(0, Deck.Instance.ZombiesDeck.Length);
            Deck.Instance.ZombiesDeck[randomCard].Counter--;
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
