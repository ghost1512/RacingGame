using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        DisplayTime();
    }


    public void DisplayTime()
    {
        timeText.SetText(Mathf.FloorToInt(GameManager.Instance.TimeFinish).ToString());
    }
}
