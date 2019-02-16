using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void PlayRespect()
    {
        Managers.UIManager.ShowRespect();
        Managers.AudioManager.PlayRespectAudio();
        Managers.AdsManager.ShowAnnoyingInter();
    }
}