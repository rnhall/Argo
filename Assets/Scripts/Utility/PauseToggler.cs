using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseToggler : MonoBehaviour
{
    [SerializeField]
    PlayerCamera playerCamera;

    [SerializeField]
    GameEvent pauseEvent;

    [SerializeField]
    GameEvent unpauseEvent;

    public bool IsCurrentlyPaused { get; set; } = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (IsCurrentlyPaused)
            {
                Debug.LogWarning("Unpause Event");
                unpauseEvent.Invoke();
            }
            else
            {
                Debug.LogWarning("Pause Event");
                pauseEvent.Invoke();
            }
        }
    }
}
