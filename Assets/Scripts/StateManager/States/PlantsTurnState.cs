using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsTurnState : State
{
    public PlantsTurnState()
    {
        StateType = StateType.PlantsTurn;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("EnterPlantsTurn");
        Cameras.Instance.CamP1.gameObject.SetActive(true);
        Cameras.Instance.CamP2.gameObject.SetActive(false);
        Cameras.Instance.BattlefieldCam.gameObject.SetActive(false);

        UIElements.Instance.CanvasP1.gameObject.SetActive(true);
        UIElements.Instance.CanvasP2.gameObject.SetActive(false);
        UIElements.Instance.PlayerOne.Draw();
    }
    public override void StateUpdate()
    {
        //base.StateUpdate();
    }
    public override void Exit()
    {
        //base.Exit();
    }

    
}
