using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    Scene activeScene;

    void Start()
    {
        Time.timeScale = 1;
        activeScene = SceneManager.GetActiveScene(); 
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(activeScene.buildIndex + 1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}