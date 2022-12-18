using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPage : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManager;
    public int starts;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetStarts);
    }

    void SetStarts()
    {
        Debug.Log(button.gameObject.name + "Game start");
        gameManager.StartGame(starts);
    }
}
