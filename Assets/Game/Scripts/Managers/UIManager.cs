using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject respectPanel;

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