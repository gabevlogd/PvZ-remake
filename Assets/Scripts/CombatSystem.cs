using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public DropZone[] DropZonesP1;
    public DropZone[] DropZonesP2;

    public List<GameObject> cardsP1;
    public List<GameObject> cardsP2;



    private void Awake()
    {
        InitializeDropZones();
        //Combat();
    }


    private void InitializeDropZones()
    {
        DropZonesP1 = new DropZone[5];
        DropZonesP2 = new DropZone[5];
        for (int i = 0; i < 5; i++)
        {
            DropZonesP1[i] = GameObject.Find("P1DZ" + i.ToString()).GetComponent<DropZone>();
        }

        for (int i = 0; i < 5; i++)
        {
            DropZonesP2[i] = GameObject.Find("P2DZ" + i.ToString()).GetComponent<DropZone>();
        }
    }

    private void Combat()
    {

        for(int i = 0; i < DropZonesP1.Length; i++)
        {
            //Debug.Log(dropZone.CardOnZone?.name);
            BaseCard cardP1 = null;
            BaseCard cardP2 = null;
            if (DropZonesP1[i].CardOnZone != null) cardP1 = DropZonesP1[i].CardOnZone;
            if (DropZonesP2[i].CardOnZone != null) cardP2 = DropZonesP2[i].CardOnZone;

            if(cardP1 != null && cardP2 != null)
            {
               // cardP1.PrefabForBattlefield.
            }
        }
    }

}
