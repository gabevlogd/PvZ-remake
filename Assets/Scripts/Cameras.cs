using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public static Cameras Instance; 
    public Camera CamP1;
    public Camera CamP2;
    public Camera BattlefieldCam;

    private void Awake()
    {
        Instance = this;
    }
}
