using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    public abstract void OnActivate();
    public abstract void OnDeactivate();
    public abstract void OnUpdate();

    public override string ToString()
    {
        return GetType().ToString();
    }
}