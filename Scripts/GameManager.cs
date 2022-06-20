using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    private int score = 0;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;

    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Pause();
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
