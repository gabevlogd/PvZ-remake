using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public BaseCard[] PlantsDeck;
    public BaseCard[] ZombiesDeck;
    public static Deck Instance;
    [HideInInspector] public int PlantsCardsDrawn;
    [HideInInspector] public int ZombiesCardsDrawn;

    private void Awake()
    {
        PlantsCardsDrawn = 0;
        ZombiesCardsDrawn = 0;
        Instance = this;
    }
}
