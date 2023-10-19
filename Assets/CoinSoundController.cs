using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CoinSoundController : MonoBehaviour
{
    private AudioSource coinSound;

    [SerializeField] private Vector2 pitchRange;
    
    // Start is called before the first frame update
    void Start()
    {
        coinSound = GetComponent<AudioSource>();
    }


    public void TriggerCoinSound()
    {
        coinSound.pitch = 1 * Random.Range(pitchRange.x, pitchRange.y);
        coinSound.Play();
    }
}
