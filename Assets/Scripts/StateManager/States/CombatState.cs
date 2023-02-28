using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatState : State
{
    public CombatState()
    {
        StateType = StateType.Combat;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("EnterCombat");
        Cameras.Instance.CamP1.gameObject.SetActive(false);
        Cameras.Instance.CamP2.gameObject.SetActive(false);
        Cameras.Instance.BattlefieldCam.gameObject.SetActive(true);

        UIElements.Instance.CanvasP1.gameObject.SetActive(false);
        UIElements.Instance.CanvasP2.gameObject.SetActive(false);

        StateManager.Instance.combatSystem.AddComponent(typeof(CombatSystem));
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
