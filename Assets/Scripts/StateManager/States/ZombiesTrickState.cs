using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesTrickState : State
{
    public ZombiesTrickState()
    {
        StateType = StateType.ZombiesTricks;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("EnterZombieTurn");
        Cameras.Instance.CamP1.gameObject.SetActive(false);
        Cameras.Instance.CamP2.gameObject.SetActive(true);
        Cameras.Instance.BattlefieldCam.gameObject.SetActive(false);

        UIElements.Instance.CanvasP1.gameObject.SetActive(false);
        UIElements.Instance.CanvasP2.gameObject.SetActive(true);
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
