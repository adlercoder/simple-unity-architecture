using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ADSManager))]
[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(GameManager))]
[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(UIManager))]
public class Managers : MonoBehaviour
{
    private static ADSManager _adsManager;
    private static AudioManager _audioManager;
    private static GameManager _gameManager;
    private static InputManager _inputManager;
    private static UIManager _uiManager;

    public static ADSManager AdsManager { get => _adsManager; }
    public static AudioManager AudioManager { get => _audioManager; }
    public static GameManager GameManager { get => _gameManager; }
    public static InputManager InputManager { get => _inputManager; }
    public static UIManager UIManager { get => _uiManager; }

    private void Awake()
    {
        _adsManager = GetComponent<ADSManager>();
        _audioManager = GetComponent<AudioManager>();
        _gameManager = GetComponent<GameManager>();
        _inputManager = GetComponent<InputManager>();
        _uiManager = GetComponent<UIManager>();

        // DontDestroyOnLoad(this);
    }
}