using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    public GameObject gameoverPanel;
    public void SetScoreText(string txt)
    {
        if (ScoreText)
        {
            ScoreText.text = txt;
        }
    }

    public void ShowGameoverPanel(bool isShow)
    {
        if (gameoverPanel)
            gameoverPanel.SetActive(isShow);
    }
}
