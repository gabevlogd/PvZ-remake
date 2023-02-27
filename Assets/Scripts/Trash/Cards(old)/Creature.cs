using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Creature", menuName = ("ScriptableObjects" + "/Cards" + "/CreateNewCreature"), order = 2)]
public class Creature : Trick
{
    public int Power;
    public int Defense;

    public void Fight() { }
    public void Die() { }
    public void SetPower(int n) { }
    public void SetDefense(int n) { }
}
