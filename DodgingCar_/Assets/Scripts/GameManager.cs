using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public TMP_Text scoreText;
    public TMP_Text livesText;

    public GameObject gameOverPanel;  // 게임오버 패널 연결용

    void Start()
    {
        UpdateUI();
        gameOverPanel.SetActive(false);  // 시작 시 게임오버 UI 끔
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;

        if (livesText != null)
            livesText.text = "Lives: " + lives;
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        gameOverPanel.SetActive(true);  // 게임오버 UI 활성화

        // 게임 일시정지 (옵션)
        Time.timeScale = 0f;
    }

    // 버튼에서 호출하는 재시작 함수
    public void RestartGame()
    {
        Time.timeScale = 1f;  // 시간 정상화
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
