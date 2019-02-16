using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Managers.GameManager.SetState(typeof(RespectState));
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Managers.GameManager.SetState(typeof(InitialState));
        }
    }
}