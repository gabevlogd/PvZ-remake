using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameState : State
{
    public EndGameState()
    {
        StateType = StateType.EndGame;
    }
    public override void Enter()
    {
        //base.Enter();
        Debug.Log("EnterEndGame");
        if (UIElements.Instance.PlayerOne.LifePoint <= 0) UIElements.Instance.ZombiesWon.gameObject.SetActive(true);
        else if(UIElements.Instance.PlayerTwo.LifePoint <= 0) UIElements.Instance.PlantsWon.gameObject.SetActive(true);
        UIElements.Instance.NewGameButton.gameObject.SetActive(true);
        UIElements.Instance.ExitButton.gameObject.SetActive(true);
        UIElements.Instance.NewGameButton.onClick.AddListener(NewGameButtonUsage);
        UIElements.Instance.ExitButton.onClick.AddListener(ExitButtonUsage);
    }
    public override void StateUpdate()
    {
        //base.StateUpdate();
    }
    public override void Exit()
    {
        //base.Exit();
    }

    private static void NewGameButtonUsage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private static void ExitButtonUsage()
    {
        Application.Quit();
    }
}
