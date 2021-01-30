using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSO : ScriptableObject
{
    [Tooltip("Name for this pickup")]
    [SerializeField]
    string pickupName;

    /// <summary>
    /// Name for this pickup
    /// </summary>
    /// <value></value>
    public string PickupName { get { return pickupName; } }
}
