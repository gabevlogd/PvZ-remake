using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrickC_3D : MonoBehaviour
{
    public ZombieTrickC RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.ZombiesDeck)
        {
            if (card.TryGetComponent(out ZombieTrickC targetCard))
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
