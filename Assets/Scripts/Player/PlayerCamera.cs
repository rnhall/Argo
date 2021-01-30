using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    bool inGame = true;

    [SerializeField]
    bool inverted = true;

    public bool Inverted
    {
        get
        {
            return inverted;
        }
        set
        {
            inverted = value;
        }
    }

    public bool InGame
    {
        get
        {
            return inGame;
        }
        set
        {
            inGame = value;
            SetAppropriateValues();
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        SetAppropriateValues();
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
            transform.Rotate(new Vector2(Input.GetAxis("Mouse Y") * (inverted ? 1 : -1), Input.GetAxis("Mouse X")), Space.Self);
            float z = transform.eulerAngles.z;
            transform.Rotate(0, 0, -z);
        }
    }

    void SetAppropriateValues()
    {
        if (inGame)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
