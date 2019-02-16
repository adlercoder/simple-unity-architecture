using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StatesBase _currentState;
    public StatesBase CurrentState { get => _currentState; }

    private void Start()
    {
        SetState(typeof(InitialState));
    }

    private void Update()
    {
        if (_currentState)
        {
            _currentState.OnUpdate();
        }
    }

    public void SetState(System.Type newStateType)
    {
        if (_currentState != null)
        {
            _currentState.OnDeactivate();
        }

        _currentState = GetComponentInChildren(newStateType) as StatesBase;

        if (_currentState != null)
        {
            _currentState.OnActivate();
        }
    }
}