using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialState : StatesBase
{
    public override void OnActivate()
    {
        Managers.UIManager.ShowStartPanel();
    }

    public override void OnDeactivate()
    {

    }

    public override void OnUpdate()
    {

    }
}