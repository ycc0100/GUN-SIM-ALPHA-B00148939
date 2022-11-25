using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManagerX : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public Button restartButton;
    public GameObject titleScreen;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
