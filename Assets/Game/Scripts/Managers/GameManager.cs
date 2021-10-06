using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BaseState Current { get; private set; }

    private void Start()
    {
        SetState(typeof(InitialState));
    }

    private void Update()
    {
        if (Current)
        {
            Current.OnUpdate();
        }
    }

    public void SetState(System.Type newStateType)
    {
        if (Current != null)
        {
            Current.OnDeactivate();
        }

        Current = GetComponentInChildren(newStateType) as BaseState;

        if (Current != null)
        {
            Current.OnActivate();
        }
    }
}