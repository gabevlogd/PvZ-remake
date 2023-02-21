using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Trick", menuName = ("ScriptableObjects" + "/Cards" + "/CreateNewTrick"), order = 1)]
public class Trick : ScriptableObject
{
    public string Name;
    public string Effect;
    public int ManaCost;
    [HideInInspector] 
    public bool Available;
    [HideInInspector]
    public int Counter = 0;

    
    public void ExecuteEffect() { }
}
