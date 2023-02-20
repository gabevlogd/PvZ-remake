using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCard : Card
{
    public int Power;
    public int Defense;

    public CreatureCard(CardType type, CardSubtype subtype) : base(type, subtype) { }
    public override void InitializedCard()
    {
        if(cardType == CardType.ZombieCard)
        {
            switch (cardSubtype)
            {
                case CardSubtype.CreatureA:
                    break;
                case CardSubtype.CreatureB:
                    break;
                case CardSubtype.CreatureC:
                    break;
                case CardSubtype.CreatureD:
                    break;
                case CardSubtype.CreatureE:
                    break;
            }
        }
        else
        {
            switch (cardSubtype)
            {
                case CardSubtype.CreatureA:
                    break;
                case CardSubtype.CreatureB:
                    break;
                case CardSubtype.CreatureC:
                    break;
                case CardSubtype.CreatureD:
                    break;
                case CardSubtype.CreatureE:
                    break;
            }
        }
    }
    public void Fight() { }
    public void Die() { }
    public void SetPower(int n) { }
    public void SetDefense(int n) { }
}
