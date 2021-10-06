using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _startPanel;
    [SerializeField]
    private GameObject _inGamePanel;
    [SerializeField]
    private GameObject _gameResultPanel;

    public void ShowStartPanel()
    {
        _startPanel.SetActive(true);
        _inGamePanel.SetActive(false);
        _gameResultPanel.SetActive(false);
        print("Start panel enabled...");
    }
    
    public void ShowInGamePanel()
    {
        _startPanel.SetActive(false);
        _inGamePanel.SetActive(true);
        print("InGame panel enabled...");
    }

    public void ShowGameResultPanel()
    {
        _inGamePanel.SetActive(false);
        _gameResultPanel.SetActive(true);
        print("GameResult panel enabled...");
    }
}