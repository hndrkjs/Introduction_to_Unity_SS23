using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Text astronautsCollected;
    [SerializeField]
    private Text lives;

    private int n_atronauts = 0;

    public void UpdateAstronautsCollected()
    {
        n_atronauts++;
        // UPDATE TEXT 
        astronautsCollected.text = "Astronauts Saved: " + n_atronauts;
    }

    public void UpdateAstronautsCollected(int health)
    {
        // UPDATE TEXT 
        lives.text = "Lives: " + health;
    }

}
