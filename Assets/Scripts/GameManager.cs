using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    [SerializeField] GameObject gameOverUI;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (!gameOverUI.activeInHierarchy)
        {
            gameOverUI.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        if (gameOverUI.activeInHierarchy)
        {
            gameOverUI.SetActive(false);
        }

        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
