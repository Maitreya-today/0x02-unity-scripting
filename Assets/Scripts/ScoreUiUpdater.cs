using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreUiUpdater : MonoBehaviour
{
    const string baseScoreTextTemplate = "Score: ";
    
    Text scoreTextElement;

    void Start(){
        scoreTextElement = GetComponent<Text>();
    }

    public void SetTextToScore(int value){
        scoreTextElement.text = baseScoreTextTemplate + value;
    }
    
}
