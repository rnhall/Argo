using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 maxSpeeds;

    [SerializeField]
    PlayerMovementDataSO movementData;

    [SerializeField]
    Rigidbody body;

    float secondsElapsed = 0;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float ascending = Input.GetAxis("Ascending");

        bool isMoving = horizontal != 0 || vertical != 0 || ascending != 0;

        secondsElapsed = Mathf.Clamp(secondsElapsed + (isMoving ? 1 : -1) * Time.fixedDeltaTime, 0, movementData.SecondsToReachMax);

        float curve = movementData.AccelerationCurve.Evaluate(Mathf.Lerp(0, 1, secondsElapsed / movementData.SecondsToReachMax));
        float x = horizontal * Time.fixedDeltaTime * maxSpeeds.x * curve;
        float y = ascending * Time.fixedDeltaTime * maxSpeeds.y * curve;
        float z = vertical * Time.fixedDeltaTime * maxSpeeds.z * curve;

        //Debug.LogWarning("Is Moving: " + isMoving + " Movement: " + x + ", " + y + ", " + z);

        body.AddRelativeForce(x, y, z, ForceMode.Impulse);
    }
}
