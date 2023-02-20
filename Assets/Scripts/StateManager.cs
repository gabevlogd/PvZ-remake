using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public State CurrentState;
    public Dictionary<StateType, State> States;

    void Start()
    {
        InitializeStates();
        CurrentState = States[StateType.Mulligan];
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.StateUpdate();
    }

    private void ChangeState(StateType stateType)
    {
        CurrentState.Exit();
        CurrentState = States[stateType];
        CurrentState.Enter();
    }

    private void InitializeStates()
    {
        States.Add(StateType.Mulligan, new MulliganState());
        States.Add(StateType.PreRound, new PreRoundState());
        States.Add(StateType.ZombiesTurn, new ZombiesTurnState());
        States.Add(StateType.PlantsTurn, new PlantsTurnState());
        States.Add(StateType.ZombiesTricks, new ZombiesTrickState());
        States.Add(StateType.Combat, new CombatState());
        States.Add(StateType.PostRound, new PostRoundState());
        States.Add(StateType.EndGame, new EndGameState());
    }
}
