using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public BaseCard[] Cards;
    private GameObject Hand;

    private void Awake()
    {
        Hand = GameObject.Find("Hand");
    }

    public void Draw()
    {
        int randomCard = Random.Range(0, Cards.Length);
        Instantiate(Cards[randomCard], Hand.transform);

    }
}
