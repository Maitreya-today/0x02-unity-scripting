using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VictoryUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject victoryUIContainer;

    private void Start()
    {
        victoryUIContainer.gameObject.SetActive(false);
    }

    public void OnVictory()
    {
        victoryUIContainer.gameObject.SetActive(true);
    }
}
