using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostAstronaut : MonoBehaviour
{
    [SerializeField]
    private UI_Manager uiManager;

    private void OnTriggerEnter(Collider other)
    {
        // we need to check that the astronaut actually collided with the character. Since the aliens are moving around, a collision
        // with an alien might be possible
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        // only the Player has an inventory
        if (playerInventory != null)
        {
            playerInventory.AstronautCollected();

            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);

            uiManager.UpdateAstronautsCollected();
            
        }


    }
}
