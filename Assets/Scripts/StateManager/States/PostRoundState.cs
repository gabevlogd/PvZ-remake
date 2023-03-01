using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostRoundState : State
{
    public PostRoundState()
    {
        StateType = StateType.PostRound;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("PostRoundEnter");
        StateManager.Instance.RoundCounter++;
        UIElements.Instance.PlayerOne.ManaBase = StateManager.Instance.RoundCounter;
        UIElements.Instance.PlayerTwo.ManaBase = StateManager.Instance.RoundCounter;
        StateManager.Instance.ChangeState(StateType.ZombiesTurn);
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
