using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIElements : MonoBehaviour
{
    public static UIElements Instance;
    [Header("Player One Elements")]
    public Canvas CanvasP1;
    public HorizontalLayoutGroup HandP1;
    public Button[] MulliganButtonsP1;
    [Header("Player Two Elements")]
    public Canvas CanvasP2;
    public HorizontalLayoutGroup HandP2;
    public Button[] MulliganButtonsP2;
    [Header("Shared Elements")]
    public Button ReadyButton;

    private void Awake()
    {
        Instance = this;
    }

    
}
