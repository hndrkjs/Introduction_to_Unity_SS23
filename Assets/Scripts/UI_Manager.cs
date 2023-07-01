using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI astronautsCollected;
    [SerializeField]
    private TextMeshProUGUI health;
    
    // this function is called in the LostAstronaut class when an astronaut detects a collision
    public void UpdateAstronautsCollected(int n_atronauts)
    {
        astronautsCollected = astronautsCollected.GetComponent<TextMeshProUGUI>();
        // UPDATE TEXT 
        astronautsCollected.text = n_atronauts.ToString();
    }

    // this function is called in the player class when it gets damaged
    public void UpdateLives(int lives)
    {
        health = health.GetComponent<TextMeshProUGUI>();
        // UPDATE TEXT 
        health.text = lives.ToString();
    }

}
