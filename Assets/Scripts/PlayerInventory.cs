using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInventory : MonoBehaviour
{
    [SerializeField]
    private UI_Manager uiManager;

    public int numberofAstronauts = 0;

    public void AstronautCollected()
    {
        numberofAstronauts++;
        uiManager.UpdateAstronautsCollected(numberofAstronauts);
    }
}
