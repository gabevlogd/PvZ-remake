using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesTurnState : State
{
    public ZombiesTurnState()
    {
        StateType = StateType.ZombiesTurn;
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
        UIElements.Instance.PassButton.gameObject.SetActive(true);
        UIElements.Instance.PassButton.onClick.AddListener(PassButtonUsage);
    }
    public override void StateUpdate()
    {
        //base.StateUpdate();
    }
    public override void Exit()
    {
        //base.Exit();
    }

    public static void PassButtonUsage()
    {
        //Debug.Log("PassButtonUsage");
        StateManager.Instance.ChangeState((StateType)(int)StateManager.Instance.CurrentState.StateType + 1);
    }
}
