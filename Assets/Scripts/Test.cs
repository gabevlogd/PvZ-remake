using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public BaseCard[] Cards;
    public Squad squad;
    public GameObject HandP1;
    public GameObject HandP2;

    private void Update()
    {
        if (UIElements.Instance.CanvasP1.gameObject.activeInHierarchy) squad = Squad.Plants;
        else if (UIElements.Instance.CanvasP2.gameObject.activeInHierarchy) squad = Squad.Zombies;
    }

    public void Draw()
    {
        if (squad == Squad.Plants && Deck.Instance.PlantsCardsDrawn < 40)
        {
            int randomCard;
            do randomCard = Random.Range(0, Deck.Instance.PlantsDeck.Length);
            while (Deck.Instance.PlantsDeck[randomCard].Counter <= 0);
            Deck.Instance.PlantsDeck[randomCard].Counter--;
            Deck.Instance.PlantsCardsDrawn++;
            Instantiate(Deck.Instance.PlantsDeck[randomCard], HandP1.transform);
        }
        else if (squad == Squad.Zombies && Deck.Instance.ZombiesCardsDrawn < 40)
        {
            int randomCard;
            do randomCard = Random.Range(0, Deck.Instance.ZombiesDeck.Length);
            while (Deck.Instance.ZombiesDeck[randomCard].Counter <= 0);
            Deck.Instance.ZombiesDeck[randomCard].Counter--;
            Deck.Instance.ZombiesCardsDrawn++;
            Instantiate(Deck.Instance.ZombiesDeck[randomCard], HandP2.transform);
        }

    }
}
