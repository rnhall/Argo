using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NoteData", menuName = "Pickup/Note", order = 10)]
public class NoteDataSO : PickupSO
{
    /// <summary>
    /// Potential order of these notes in inventory
    /// </summary>
    [SerializeField]
    int order;

    /// <summary>
    /// Text that should be displayed to the player
    /// </summary>
    [TextArea(5,8)]
    [SerializeField]
    string contents;

    /// <summary>
    /// Text that should be displayed to the player
    /// </summary>
    /// <value></value>
    public string Contents
    {
        get
        {
            return contents;
        }
    }
}
