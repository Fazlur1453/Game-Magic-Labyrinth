using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayManager : MonoBehaviour
{

    [SerializeField] GameObject finishedCanvas;

    [SerializeField] GameObject failedCanvas;

    [SerializeField] TMP_Text finishedText;

   

    int coin = 100;

    public void GameOver()
    {
        failedCanvas.SetActive(true);
        Debug.Log("GameOver");
    }

    public void Win()
    {
        finishedCanvas.SetActive(true);
        finishedText.text = "You Win!\nScore:" + GetScore();
        Debug.Log("Win");
    }

    private int GetScore()
    {
       return coin * 10;
    }
}
