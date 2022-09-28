using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int best;
    public int score;
    public int currentStage = 0;
    public static GameManager singleton;
    public SnakeController controller;
    public float levelRestartDelay = 2f;

    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (score > best)
        {
            best = score;
            PlayerPrefs.SetInt("Hightscore", score);
        }
    }

    public void NextLevel()
    {
        Debug.Log("Next level called");
    }

    
    public void EndGame()
    {
        controller.enabled = false;        
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        singleton.score = 0;
    }
}

