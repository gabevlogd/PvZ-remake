using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickB_3D : MonoBehaviour
{
    public PlantTrickB RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.PlantsDeck)
        {
            if (card.TryGetComponent(out PlantTrickB targetCard))
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
