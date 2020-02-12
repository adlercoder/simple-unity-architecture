using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject respectPanel;

    public void ShowRespectPanel()
    {
        startPanel.SetActive(false);
        respectPanel.SetActive(true);
        print("Respect panel showing...");
    }

    public void ShowStartPanel()
    {
        startPanel.SetActive(true);
        respectPanel.SetActive(false);
        print("Start panel showing...");
    }
}