using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Managers.GameManager.SetState(typeof(InitialState));
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Managers.GameManager.SetState(typeof(InGameState));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Managers.GameManager.SetState(typeof(GameResultState));
        }
    }
}