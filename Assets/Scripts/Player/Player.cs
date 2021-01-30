using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

public class Player : MonoBehaviour
{
    [SerializeField]
    List<NoteDataSO> collectedNotes = new List<NoteDataSO>();


    public ReadOnlyCollection<NoteDataSO> CollectedNotes { get { return collectedNotes.AsReadOnly(); } }

    [SerializeField]
    List<PickupSO> otherPickups = new List<PickupSO>();

    public ReadOnlyCollection<PickupSO> OtherPickups { get { return otherPickups.AsReadOnly(); } }

    public void AddPickup(PickupSO pickup)
    {
        if (pickup is NoteDataSO && !collectedNotes.Contains((NoteDataSO)pickup))
        {
            collectedNotes.Add((NoteDataSO)pickup);
        }
        else
        {
            otherPickups.Add(pickup);
        }
    }
}
