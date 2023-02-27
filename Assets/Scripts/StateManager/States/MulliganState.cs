using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MulliganState : State
{
    private static MulliganState m_Instance;
    private Selectable[] m_cardsToChange;
    private GameObject[] m_replacedCards;
    private int m_index;
    private int m_playersReady;


    public MulliganState()
    {
        m_Instance = this;
        StateType = StateType.Mulligan;
        m_cardsToChange = new Selectable[4];
        m_replacedCards = new GameObject[4];
        m_index = 0;
        m_playersReady = 0;
    }


    public override void Enter()
    {
        foreach (Button button in UIElements.Instance.MulliganButtons)
        {
            button.gameObject.SetActive(true);
            button.onClick.AddListener(ReplaceCardButtonUsage);
        }
        UIElements.Instance.ReadyButton.gameObject.SetActive(true);
        UIElements.Instance.ReadyButton.onClick.AddListener(ReadyButton);
    }

    public override void StateUpdate()
    {
        //base.StateUpdate();
        if (m_playersReady >= 2) StateManager.Instance.ChangeState(StateType.PreRound);
    }
    public override void Exit()
    {
        //base.Exit();
        UIElements.Instance.ReadyButton.gameObject.SetActive(false);
    }


    public static void ReplaceCardButtonUsage()
    {
        //Debug.Log("ReplaceCardButtonUsage");
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        //Debug.Log(EventSystem.current.currentSelectedGameObject.GetComponent<Button>().FindSelectableOnDown().name);

        Selectable cardToChange = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().FindSelectableOnDown();
        BaseCard newCard;

        if (cardToChange.GetComponent<BaseCard>().Type == CardType.Plant) newCard = Instantiate(Deck.Instance.PlantsDeck[Random.Range(0, Deck.Instance.PlantsDeck.Length)], cardToChange.transform.position, Quaternion.identity);
        else newCard = Instantiate(Deck.Instance.ZombiesDeck[Random.Range(0, Deck.Instance.ZombiesDeck.Length)], cardToChange.transform.position, Quaternion.identity);

        cardToChange.GetComponent<BaseCard>().Counter++;
        newCard.transform.SetParent(EventSystem.current.currentSelectedGameObject.transform.parent);
        EventSystem.current.currentSelectedGameObject.SetActive(false);

        m_Instance.m_cardsToChange[m_Instance.m_index] = cardToChange;
        m_Instance.m_replacedCards[m_Instance.m_index] = newCard.gameObject;
        if (m_Instance.m_index < 4) m_Instance.m_index++;
    }

    public static void ReadyButton()
    {
        //Debug.Log("ReadyButton");
        foreach (Selectable card in m_Instance.m_cardsToChange) if (card != null) Destroy(card.gameObject);
        foreach (GameObject card in m_Instance.m_replacedCards)
        {
            if (card != null)
            {
                if(card.GetComponent<BaseCard>().Type == CardType.Plant) card.transform.SetParent(UIElements.Instance.HandP1.transform);
                else card.transform.SetParent(UIElements.Instance.HandP2.transform);
            } 
        }
        m_Instance.m_playersReady++;
        if (m_Instance.m_playersReady < 2) m_Instance.OnMulliganExitP1();
        else m_Instance.OnMulliganExitP2();

    }

    public void OnMulliganExitP1()
    {
        //Debug.Log("OnMulliganExitP1");
        Cameras.Instance.CamP1.gameObject.SetActive(false);
        Cameras.Instance.CamP2.gameObject.SetActive(true);
        UIElements.Instance.CanvasP1.gameObject.SetActive(false);
        UIElements.Instance.CanvasP2.gameObject.SetActive(true);
        foreach (Button button in UIElements.Instance.MulliganButtons) button.gameObject.SetActive(true);
        m_Instance.m_cardsToChange = new Selectable[4];
        m_Instance.m_replacedCards = new GameObject[4];
        m_Instance.m_index = 0;

    }

    public void OnMulliganExitP2()
    {
        //Debug.Log("OnMulliganExitP2");
        foreach (Button button in UIElements.Instance.MulliganButtons) button.gameObject.SetActive(false);
    }


}