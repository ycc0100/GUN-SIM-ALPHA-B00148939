using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerX : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public Button button;
    public GameObject titleScreen;

    public bool isGameActive;

    private int score;

    // Start is called before the first frame update
    public void StartGame(int starts)
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        titleScreen.SetActive(false);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

}
