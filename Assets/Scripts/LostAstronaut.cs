using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostAstronaut : MonoBehaviour
{
    [SerializeField]
    private UI_Manager uiManager;

    private void OnTriggerEnter(Collider other)
    {

        // check whether the astronaut was collected by the player
        if (other.CompareTag("Player"))
        {
            // get the player's inventory to increase the number of collected astronauts
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            playerInventory.AstronautCollected();

            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);

            //uiManager.UpdateAstronautsCollected();
            
        }


    }
}
