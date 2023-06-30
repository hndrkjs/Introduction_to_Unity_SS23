using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int numberofAstronauts {get; private set;}

    public void AstronautCollected()
    {
        numberofAstronauts++;
    }
}
