using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractRaycast : MonoBehaviour
{
    [SerializeField]
    float interactableDistance;

    [SerializeField]
    Player player;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            RaycastHit hit;
            LayerMask mask = ~LayerMask.GetMask("Player"); //Collide with everything except player
            Debug.LogWarning("Mask: " + mask + " Value: " + mask.value);
            if (Physics.Raycast(transform.position, transform.forward * interactableDistance, out hit, interactableDistance, mask))
            {
                Debug.LogWarning("Hit object: " + hit.collider.gameObject.name);
                var pickup = hit.collider.gameObject.GetComponentInParent<Pickup>();
                if (pickup != null)
                {
                    pickup.GetPickup(player);
                }
            }

            Debug.DrawRay(transform.position, transform.forward * interactableDistance, Color.white, 3, false);
        }
    }
}
