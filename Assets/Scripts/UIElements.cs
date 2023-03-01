using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIElements : MonoBehaviour
{
    public Player PlayerOne;
    public Player PlayerTwo;

    public static UIElements Instance;
    [Header("Player One Elements")]
    public Canvas CanvasP1;
    public HorizontalLayoutGroup HandP1;
    public Text LifePointP1;
    public Text ManaP1;
    [Header("Player Two Elements")]
    public Canvas CanvasP2;
    public HorizontalLayoutGroup HandP2;
    public Text LifePointP2;
    public Text ManaP2;
    [Header("Shared Elements")]
    public Button[] MulliganButtons;
    public Button ReadyButton;
    public Button PassButton;
    public Button NewGameButton;
    public Button ExitButton;
    public Image PlantsWon;
    public Image ZombiesWon;
    public Text CardEffect;
    public CardInfo CardInfo;

    private void Awake()
    {
        Instance = this;
        
    }

    private void Update()
    {
        LifePointP1.text = PlayerOne.LifePoint.ToString();
        LifePointP2.text = PlayerTwo.LifePoint.ToString();
        ManaP1.text = PlayerOne.ManaBase.ToString();
        ManaP2.text = PlayerTwo.ManaBase.ToString();
    }


}
