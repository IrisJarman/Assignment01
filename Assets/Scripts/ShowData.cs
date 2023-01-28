using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelSpeedText;

    private void Awake()
    {
        PanelNameText.text = "Name: " + KeepData1.PlayerName;
        PanelSpeedText.text = "Speed: " + KeepData1.PlayingSpeed.ToString();

    }
    
}
