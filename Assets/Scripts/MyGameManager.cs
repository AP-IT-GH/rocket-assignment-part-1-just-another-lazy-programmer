using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyGameManager : MonoBehaviour
{
    public enum GameState { Playing, GameOver, Victory }

    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameObject VictoryCanvas;
    public GameState gameState;
    public GameObject VictoryScoreDisplay;
    private Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
            Player = GameObject.FindWithTag("Player");

        playerHealth = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.Playing:

                if (!playerHealth.isAlive)
                {
                    gameState = GameState.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }

                break;
            case GameState.GameOver:
                break;
            
            case GameState.Victory:
                break;
        }
    }

    public void Victory()
    {
        if (gameState == GameState.Playing)
            gameState = GameState.Victory;

        MainCanvas.SetActive(false);
        VictoryCanvas.SetActive(true);

        var scoreComponent = VictoryScoreDisplay.GetComponent<TextMeshProUGUI>();
        scoreComponent.text = $"{Player.GetComponent<Points>().GetScore()} Points";
    }
}
