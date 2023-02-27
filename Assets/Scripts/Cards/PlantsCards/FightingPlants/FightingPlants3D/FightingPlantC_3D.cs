using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingPlantC_3D : MonoBehaviour
{
    public FightingPlantC RepresentedCard;
    public TextMesh Power;
    public TextMesh Defense;

    private void Awake()
    {
        Power.text = RepresentedCard.POWER.ToString();
        Defense.text = RepresentedCard.DEFENSE.ToString();
    }

}
