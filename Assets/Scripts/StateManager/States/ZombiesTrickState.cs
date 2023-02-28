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
        Debug.Log("EnterZombiesTricks");
        Cameras.Instance.CamP1.gameObject.SetActive(false);
        Cameras.Instance.CamP2.gameObject.SetActive(true);
        Cameras.Instance.BattlefieldCam.gameObject.SetActive(false);

        UIElements.Instance.CanvasP1.gameObject.SetActive(false);
        UIElements.Instance.CanvasP2.gameObject.SetActive(true);
        UIElements.Instance.PassButton.onClick.RemoveAllListeners();
        UIElements.Instance.PassButton.onClick.AddListener(PassButtonUsage);

    }
    public override void StateUpdate()
    {
        //base.StateUpdate();
    }
    public override void Exit()
    {
        //base.Exit();
        UIElements.Instance.PassButton.onClick.RemoveAllListeners();
        UIElements.Instance.PassButton.gameObject.SetActive(false);
    }

    public static void PassButtonUsage()
    {
        //Debug.Log("PassButtonUsage");
        StateManager.Instance.ChangeState(StateType.Combat);
    }
}
