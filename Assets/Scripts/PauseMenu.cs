using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu Instance;
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;
    public static bool isPaused;

    void Start()
    {
        _pauseMenu.SetActive(false);
    }

    public void PauseGame()
    {
        _pauseMenu.SetActive(true);
        _pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {

        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ToRestart()
    {
        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene("playscene");
    }

    public void ToMainMenu()
    {
        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene("mainmenuscene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
