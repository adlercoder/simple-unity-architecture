using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatesBase : MonoBehaviour
{
    public abstract void OnActivate();
    public abstract void OnDeactivate();
    public abstract void OnUpdate();

    public override string ToString()
    {
        return this.GetType().ToString();
    }
}