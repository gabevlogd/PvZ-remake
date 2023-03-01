using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrickC_3D : MonoBehaviour
{
    public PlantTrickC RepresentedCard;

    private void Awake()
    {
        foreach (BaseCard card in Deck.Instance.PlantsDeck)
        {
            if (card.TryGetComponent(out PlantTrickC targetCard))
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
