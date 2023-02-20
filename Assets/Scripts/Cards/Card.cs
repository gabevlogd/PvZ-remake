using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string Name;
    public string Effect;
    public int ManaCost;
    public bool Available;
    public CardType cardType;
    public CardSubtype cardSubtype;

    public Card(CardType type, CardSubtype subtype)
    {
        cardType = type;
        cardSubtype = subtype;
        Available = true;
    }
    public virtual void InitializedCard()
    {
        if(cardType == CardType.ZombieCard)
        {
            switch (cardSubtype)
            {
                case CardSubtype.TrickA:
                    break;
                case CardSubtype.TrickB:
                    break;
                case CardSubtype.TrickC:
                    break;
                case CardSubtype.TrickD:
                    break;
                case CardSubtype.TrickE:
                    break;
            }
        }
        else
        {
            switch (cardSubtype)
            {
                case CardSubtype.TrickA:
                    break;
                case CardSubtype.TrickB:
                    break;
                case CardSubtype.TrickC:
                    break;
                case CardSubtype.TrickD:
                    break;
                case CardSubtype.TrickE:
                    break;
            }
        }
    }
    public void ExecuteEffect() { }
    public void PlaceCard() { }
    public void ShowInfo() { }

}

public enum CardType
{
    ZombieCard,
    PlantCard
}

public enum CardSubtype
{
    TrickA,
    TrickB,
    TrickC,
    TrickD,
    TrickE,
    CreatureA,
    CreatureB,
    CreatureC,
    CreatureD,
    CreatureE
}
