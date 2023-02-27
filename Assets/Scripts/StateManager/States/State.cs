using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public StateType StateType;

    //public State() { }
    public virtual void Enter() { }

    public virtual void StateUpdate() { }

    public virtual void Exit() { }
}

public enum StateType
{
    Mulligan,
    PreRound,
    ZombiesTurn,
    PlantsTurn,
    ZombiesTricks,
    Combat,
    PostRound,
    EndGame
}
