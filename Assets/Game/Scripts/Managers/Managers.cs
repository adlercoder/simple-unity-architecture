using UnityEngine;

[RequireComponent(typeof(AdsManager))]
[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(GameManager))]
[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(UIManager))]
public class Managers : MonoBehaviour
{
    public static AdsManager AdsManager { get; private set; }
    public static AudioManager AudioManager { get; private set; }
    public static GameManager GameManager { get; private set; }
    public static InputManager InputManager { get; private set; }
    public static UIManager UIManager { get; private set; }

    private void Awake()
    {
        AdsManager = GetComponent<AdsManager>();
        AudioManager = GetComponent<AudioManager>();
        GameManager = GetComponent<GameManager>();
        InputManager = GetComponent<InputManager>();
        UIManager = GetComponent<UIManager>();
    }
}