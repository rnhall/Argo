using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerMovementData", menuName = "Player/Movement")]
public class PlayerMovementDataSO : ScriptableObject
{
    [SerializeField]
    AnimationCurve accelerationCurve;

    public AnimationCurve AccelerationCurve
    {
        get
        {
            return accelerationCurve;
        }
    }

    [SerializeField]
    float secondsToReachMax;

    public float SecondsToReachMax
    {
        get
        {
            return secondsToReachMax;
        }
    }
}
