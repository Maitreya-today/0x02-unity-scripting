using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

public class GameEventCaller : MonoBehaviour
{
    [SerializeField] private GameEvent myEvent;


    public void Trigger()
    {
        myEvent.Raise();
    }
}