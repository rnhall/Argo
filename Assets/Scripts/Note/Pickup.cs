using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    PickupSO pickupData;

    [SerializeField]
    GameEvent pickupEvent;

    public void GetPickup(Player player)
    {
        player.AddPickup(pickupData);
        pickupEvent.Invoke();
        gameObject.SetActive(false);
    }
}
