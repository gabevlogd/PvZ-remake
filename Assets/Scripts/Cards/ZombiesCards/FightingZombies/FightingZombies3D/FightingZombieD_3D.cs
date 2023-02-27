using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingZombieD_3D : MonoBehaviour
{
    public FightingZombieD RepresentedCard;
    public TextMesh Power;
    public TextMesh Defense;

    private void Awake()
    {
        Power.text = RepresentedCard.POWER.ToString();
        Defense.text = RepresentedCard.DEFENSE.ToString();
    }
}
