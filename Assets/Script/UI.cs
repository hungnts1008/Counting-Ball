using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    // Start is called before the first frame update
    public GameObject GameOverPanel;
    public void SetScoreText(string txt)
    {
        if (ScoreText) ScoreText.text = txt; 
    }
    public void ShowGameOver(bool ok)
    {
        GameOverPanel.SetActive(ok);
    }
}
