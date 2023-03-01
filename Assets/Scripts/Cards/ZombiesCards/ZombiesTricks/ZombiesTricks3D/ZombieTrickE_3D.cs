using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrickE_3D : MonoBehaviour
{
    public ZombieTrickE RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.ZombiesDeck)
        {
            if (card.TryGetComponent(out ZombieTrickE targetCard))
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
