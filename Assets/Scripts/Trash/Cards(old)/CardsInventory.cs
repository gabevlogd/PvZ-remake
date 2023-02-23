using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsInventory : MonoBehaviour
{
    public Trick[] PlantsCards;
    public Trick[] ZombiesCards;
    public static CardsInventory Instance;

    private void Awake()
    {
        Instance = this;
    }
}
