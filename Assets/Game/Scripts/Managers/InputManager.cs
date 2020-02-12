using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Managers.GameManager.SetState(typeof(Respect));
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Managers.GameManager.SetState(typeof(Initial));
        }
    }
}