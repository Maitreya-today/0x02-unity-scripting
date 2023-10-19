using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

public class IntEventCaller : MonoBehaviour
{
    [SerializeField] private IntGameEvent myEvent;

    private int score;

    private void Start()
    {
        score = 0;
    }

    public void Trigger()
    {
        score++;
        myEvent.Raise(score);
    }
}
