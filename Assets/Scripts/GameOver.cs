using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public GameObject gameOverMenu;

  void Start() {
    gameOverMenu.SetActive(false);
  }

  void Update() {
    if(Player.lives <= 0) {
      Time.timeScale = 0f;
      gameOverMenu.SetActive(true);
    }
  }

  public void Restart() {
    Debug.Log("Restarting the game...");
    Player.lives = 3;
    gameOverMenu.SetActive(false);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1f;

  }

  public void LoadMenu() {
    Debug.Log("Load Menu");
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame() {
    Debug.Log("Quit Game");
    Application.Quit();
  }
}
