using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrickD_3D : MonoBehaviour
{
    public ZombieTrickD RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.ZombiesDeck)
        {
            if (card.TryGetComponent(out ZombieTrickD targetCard))
            {
                //Debug.Log(targetCard.ManaCost.text);
                RepresentedCard = targetCard;
            }
        }
    }
    private void Start()
    {
        RepresentedCard.ExecuteEffect();
        Destroy(gameObject); //Meaningless implementation, but I don't have time
    }
}
