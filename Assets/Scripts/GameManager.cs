using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private GameObject GameOverScreen;

    public bool isGameOver = false;
    public float score;

    void Start()
    {
        Time.timeScale = 1;
        Instance = this;
    }

    public void ScoreUpdate(float scoreToAdd) {
        score += scoreToAdd;

        scoreTxt.text = score.ToString();
    }

    public void GameOver() {
        isGameOver = true;
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);
    }

    public void Reset() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
