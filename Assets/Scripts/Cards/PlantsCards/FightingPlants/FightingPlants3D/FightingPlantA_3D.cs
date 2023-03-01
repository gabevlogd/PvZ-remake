using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingPlantA_3D : FightingCard3D
{

    private void Awake()
    {
        Power.text = RepresentedCard.Power.text;
        Defense.text = RepresentedCard.Defense.text;
    }

    private void Start()
    {
        RepresentedCard.ExecuteEffect();
    }

    private void Update()
    {
        Power.text = RepresentedCard.Power.text;
        Defense.text = RepresentedCard.Defense.text;
        if (Int32.Parse(Defense.text) <= 0) Destroy(gameObject, 2f);
    }

    private void OnMouseEnter()
    {
        //Debug.Log("OnMouseEnter");
        RepresentedCard.ShowInfo();
    }

    private void OnMouseExit()
    {
        RepresentedCard.HideInfo();
    }

}
