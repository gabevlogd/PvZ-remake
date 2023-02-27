using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StateManager : MonoBehaviour
{
    public static StateManager Instance;
    public State CurrentState;
    public Dictionary<StateType, State> States;
    //public UnityEvent OnChangeState;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        InitializeStates();
        CurrentState = States[StateType.Mulligan];
        CurrentState.Enter();
    }


    void Update()
    {
        CurrentState.StateUpdate();
    }

    public void ChangeState(StateType stateType)
    {
        CurrentState.Exit();
        CurrentState = States[stateType];
        CurrentState.Enter();
    }

    private void InitializeStates()
    {
        States = new Dictionary<StateType, State>();
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
