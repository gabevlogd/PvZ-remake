using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRoundState : State
{
    public PreRoundState()
    {
        StateType = StateType.PreRound;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("PreRoundEnter");

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
