using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public BaseCard[] PlantsDeck;
    public BaseCard[] ZombiesDeck;
    public static Deck Instance;

    private void Awake()
    {
        Instance = this;
    }
}
