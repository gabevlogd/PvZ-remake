using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class BaseCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject PrefabForBattlefield;
    public Text Name;
    public Text Effect;
    public Text ManaCost;
    [HideInInspector] public int Counter;
    [HideInInspector] public CardType Type;
    [HideInInspector] public CardSubtype Subtype;


    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        //ShowInfo();
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        //HideInfo();
    }
    

    public abstract void InitializeCard();
    public virtual void ExecuteEffect()
    {
        StartCoroutine(ShowEffectInfo());
    }
    public virtual void ShowInfo()
    {
        UIElements.Instance.CardInfo.Name.text = "Name: " + Name.text;
        UIElements.Instance.CardInfo.Effect.text = "Effect: " + Effect.text;
        UIElements.Instance.CardInfo.ManaCost.text = "Mana cost: " + ManaCost.text;
        UIElements.Instance.CardInfo.gameObject.SetActive(true);
    }
    public virtual void HideInfo()
    {
        UIElements.Instance.CardInfo.gameObject.SetActive(false);
    }

    public IEnumerator ShowEffectInfo()
    {
        UIElements.Instance.CardEffect.text = Effect.text;
        UIElements.Instance.CardEffect.transform.parent.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        UIElements.Instance.CardEffect.transform.parent.gameObject.SetActive(false);
    }

}

public enum CardType
{
    Zombie,
    Plant
}

public enum CardSubtype
{
    Fighting,
    Trick
}


