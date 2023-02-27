using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsInventory : MonoBehaviour
{
    public BaseCard[] PlantsCards;
    public BaseCard[] ZombiesCards;
    public static CardsInventory Instance;

    private void Awake()
    {
        Instance = this;
    }
}
